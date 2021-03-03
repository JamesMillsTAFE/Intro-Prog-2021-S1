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
        calculator.SetNumber(number);
    }
}
