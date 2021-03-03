using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Calculator : MonoBehaviour
{
    public float leftHandSide = 0;
    public float rightHandSide = float.PositiveInfinity;

    // The function that is currently being applied to the left and right hand side variables
    public FunctionalButton.Function currentFunction;

    [SerializeField]
    private TextMeshProUGUI outputDisplay;

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

        return (leftHandSide + rightHandSide).ToString();
    }
}
