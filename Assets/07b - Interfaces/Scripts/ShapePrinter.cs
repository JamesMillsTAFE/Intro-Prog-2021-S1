using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapePrinter : MonoBehaviour
{
    private TwoDimensionalShape[] shapes;

    // Start is called before the first frame update
    void Start()
    {
        shapes = gameObject.GetComponentsInChildren<TwoDimensionalShape>();

        foreach (TwoDimensionalShape shape in shapes)
        {
            Debug.LogError($"{shape.Name} : {shape.Width},{shape.Height} : Area = {shape.Area()} : Perimeter = {shape.Perimeter()}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
