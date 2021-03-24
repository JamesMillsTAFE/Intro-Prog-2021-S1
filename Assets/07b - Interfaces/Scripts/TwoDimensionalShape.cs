using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TwoDimensionalShape : MonoBehaviour, IShape, I2DMaths
{
    public float Height => height;

    public float Width => width;

    public abstract string Name { get; }

    [SerializeField]
    private float height = 5;
    [SerializeField]
    private float width = 5;

    public abstract float Area();

    public abstract float Perimeter();
}
