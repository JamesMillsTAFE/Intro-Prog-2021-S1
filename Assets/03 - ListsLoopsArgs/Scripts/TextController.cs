using UnityEngine;

using TMPro;

public class TextController : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro text;

    public void SetText(string _text)
    {
        // Set the textmesh's text value to the passed argument
        text.text = _text;
    }
}
