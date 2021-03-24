using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Image))]
[ExecuteInEditMode]
public class Shape : MonoBehaviour
{
    [SerializeField]
    protected Image image;
    [SerializeField]
    protected Sprite sprite; // Yum
    [SerializeField, Min(0.1f)]
    protected float width = 0.1f;
    [SerializeField, Min(0.1f)]
    protected float height = 0.1f;

    // Virtual means anything inheriting this class can change the functionality
    // of the virtual method/property
    // Protected means that anything inherting this class can access it, but nothing
    // outside the class 'family'
    // Start is called before the first frame update
    protected virtual void Start()
    {
        // Set the image component's sprite to the sprite of our object
        image = gameObject.GetComponent<Image>();
        image.sprite = sprite;
        image.type = Image.Type.Sliced;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Debug.Log($"{GetShapeName()} : {CalculateArea()}");

        // Change the width and height of the sprite based on the variables
        RectTransform rTransform = gameObject.GetComponent<RectTransform>();
        rTransform.sizeDelta = new Vector2(width * 100, height * 100);
    }

    /// <summary>
    /// Uses simple equations to calculate the area of whatever shape
    /// this type is. By Default it returns width * height
    /// </summary>
    public virtual float CalculateArea()
    {
        return width * height;
    }

    /// <summary>
    /// Returns the name of this shape for displaying in messages
    /// By default it is 'Shape'
    /// </summary>
    public virtual string GetShapeName()
    {
        return "Shape";
    }
}
