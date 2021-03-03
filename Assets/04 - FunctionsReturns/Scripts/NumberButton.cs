using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(Button))]
[AddComponentMenu("UI/Number Button")]
public class NumberButton : MonoBehaviour
{
    [SerializeField, Range(0, 9)]
    private int number = 0;

    private TextMeshProUGUI buttonText;
    private Button button;

    private Calculator calculator;

    // Start is called before the first frame update
    void Start()
    {
        calculator = gameObject.GetComponentInParent<Calculator>();

        buttonText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        buttonText.text = number.ToString();

        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        // Get the current float value from the calc and turn it into a string
        float currentFloat = calculator.leftHandSide;
        string lhsString = currentFloat.ToString();

        // if the string is already too long, ignore it
        if(lhsString.Replace(".", "").Length > 6)
        {
            return;
        }

        // Add this number's value to the string as text
        lhsString += number.ToString();

        // Convert the string back into a float
        calculator.leftHandSide = float.Parse(lhsString);
    }
}
