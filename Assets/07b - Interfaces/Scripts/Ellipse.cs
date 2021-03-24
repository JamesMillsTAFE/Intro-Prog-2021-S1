using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipse : TwoDimensionalShape
{
    public override string Name => "Ellipse";

    public override float Area() => Mathf.PI * Width * Height;

    public override float Perimeter()
    {
        float a = Mathf.Pow(Width, 2);
        float b = Mathf.Pow(Height, 2);
        float sqrRoot = Mathf.Sqrt((a + b) / 2);

        return 2 * Mathf.PI * sqrRoot;
    }
}
