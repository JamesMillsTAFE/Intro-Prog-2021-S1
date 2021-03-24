using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        image.type = UnityEngine.UI.Image.Type.Simple;
    }

    public override float CalculateArea()
    {
        return Mathf.PI * base.CalculateArea();
    }

    public override string GetShapeName()
    {
        return "Ellipse";
    }
}
