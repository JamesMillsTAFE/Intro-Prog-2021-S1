using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour, IShape
{
    public float Height => height;

    public float Width => width;

    public string Name => "Rectangle";

    [SerializeField]
    private float height = 5;
    [SerializeField]
    private float width = 5;
}
