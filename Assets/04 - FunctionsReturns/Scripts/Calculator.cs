using UnityEngine;

using TMPro;

public class Calculator : MonoBehaviour
{
    public float leftHandSide = 0;
    public float rightHandSide = float.PositiveInfinity;
    // The final value after operator has been applied
    public float calculatedValue = float.PositiveInfinity;

    // The function that is currently being applied to the left and right hand side variables
    [System.NonSerialized]
    public FunctionalButton.Function currentFunction = FunctionalButton.Function.None;

    [SerializeField]
    private TextMeshProUGUI outputDisplay;

    public void ClearHistory()
    {
        leftHandSide = 0;
        rightHandSide = float.PositiveInfinity;
        calculatedValue = float.PositiveInfinity;
        currentFunction = FunctionalButton.Function.None;
    }

    public void SetFunction(FunctionalButton.Function _function)
    {
        currentFunction = _function;
        rightHandSide = 0;
    }

    public void Backspace()
    {
        string valueString = GetValueString();

        valueString = valueString.Substring(0, valueString.Length - 1);

        SetValue(valueString);
    }

    private string GetValueString()
    {
        // Get the current float value from the calc and turn it into a string
        float currentFloat = leftHandSide;
        if (currentFunction != FunctionalButton.Function.None)
        {
            // We are currently trying to apply an operator so modify the second number
            currentFloat = rightHandSide;
        }

        return currentFloat.ToString();
    }

    private void SetValue(string _value)
    {
        // Convert the string back into a float
        float currentFloat = float.Parse(_value);
        // If we are applying an operator, set the right hand side to the value, otherwise the lhs
        if (currentFunction != FunctionalButton.Function.None)
        {
            rightHandSide = currentFloat;
        }
        else
        {
            leftHandSide = currentFloat;
        }
    }

    public void SetNumber(int _number)
    {
        if (!float.IsPositiveInfinity(calculatedValue))
        {
            // Reset the values here
            leftHandSide = calculatedValue;
            rightHandSide = 0;
            calculatedValue = float.PositiveInfinity;
        }

        string lhsString = GetValueString();

        // if the string is already too long, ignore it
        if (lhsString.Replace(".", "").Length > 6)
        {
            return;
        }

        // Add this number's value to the string as text
        lhsString += _number.ToString();

        SetValue(lhsString);
    }

    public void Calculate()
    {
        switch (currentFunction)
        {
            case FunctionalButton.Function.Modulus:
                calculatedValue = leftHandSide % rightHandSide;
                break;
            case FunctionalButton.Function.Divide:
                calculatedValue = leftHandSide / rightHandSide;
                break;
            case FunctionalButton.Function.Multiply:
                calculatedValue = leftHandSide * rightHandSide;
                break;
            case FunctionalButton.Function.Subtract:
                calculatedValue = leftHandSide - rightHandSide;
                break;
            case FunctionalButton.Function.Add:
                calculatedValue = leftHandSide + rightHandSide;
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        outputDisplay.text = GetOutputDisplay();
    }

    private string GetOutputDisplay()
    {
        // Is the right hand side non-existant
        if(float.IsPositiveInfinity(rightHandSide))
        {
            return leftHandSide.ToString();
        }
        // Is the calculated value set?
        else if(float.IsPositiveInfinity(calculatedValue) && !float.IsPositiveInfinity(rightHandSide))
        {
            return rightHandSide.ToString();
        }

        return calculatedValue.ToString();
    }
}
