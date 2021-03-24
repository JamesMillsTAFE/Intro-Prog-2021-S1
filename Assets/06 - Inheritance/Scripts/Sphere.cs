using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Circle
{
    [SerializeField, Min(0.1f)]
    private float radius = 0.1f;
    [SerializeField, Min(0.1f)]
    protected float depth = 0.1f;

    // Start is called before the first frame update
    protected override void Start()
    {
        depth = radius;
        width = radius;
        height = radius;
    }

    protected override void Update()
    {
        Debug.Log($"{GetShapeName()} : {CalculateArea()}");
    }

    // Implement this OnDrawGizmos if you want to draw gizmos that are also pickable and always drawn
    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, radius);
    }

    public override float CalculateArea()
    {
        // Mathf.Pow is putting the first number to the power of the second
        return 4 * Mathf.PI * Mathf.Pow(radius, 2);
    }

    public override string GetShapeName()
    {
        return "Sphere";
    }
}
