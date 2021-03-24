using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ellipsoid : Sphere
{
    // Start is called before the first frame update
    protected override void Start()
    {
        // You do nothing Jon Snow
    }

    public override float CalculateArea()
    {
        float ab = Mathf.Pow(width * height, 1.6f);
        float ac = Mathf.Pow(width * depth, 1.6f);
        float bc = Mathf.Pow(height * depth, 1.6f);

        return 4 * Mathf.PI * Mathf.Pow((ab + ac + bc) / 3, 1 / 1.6f);
    }

    public override string GetShapeName()
    {
        return "Ellipsoid";
    }

    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        Matrix4x4 matrix = Gizmos.matrix;

        Gizmos.matrix = Matrix4x4.TRS(transform.position, Quaternion.identity, new Vector3(width, height, depth));
        Gizmos.DrawSphere(Vector3.zero, 1);
        Gizmos.matrix = matrix;
    }
}
