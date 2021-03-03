using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(Button))]
public class NumberButton : MonoBehaviour
{
    [SerializeField, Range(0, 9)]
    private int number = 0;
    [SerializeField]
    private TextMeshProUGUI buttonText;

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        buttonText.text = number.ToString();

        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        Debug.Log(number);
    }
}
