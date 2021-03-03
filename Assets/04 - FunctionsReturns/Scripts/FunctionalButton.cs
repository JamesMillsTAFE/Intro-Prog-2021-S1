using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[AddComponentMenu("UI/Functional Button")]
public class FunctionalButton : MonoBehaviour
{
    public enum Function
    {
        Modulus,
        ClearHistory,
        Clear,
        Delete,
        Divide,
        Multiply,
        Subtract,
        Add,
        Equals,
        Decimal
    }

    [SerializeField]
    private Function function = Function.Equals;

    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        Debug.Log(function.ToString());
    }
}
