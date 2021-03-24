using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Abstract classes even when being a MonoBehaviour, cannot be added to GameObjects
// as components as you cannot create an instance of abstract classes. Any classes
// with any abstract functions MUST be marked as Abstract
public abstract class Person : MonoBehaviour
{
    // Abstract functions cannot have a method body and can only
    // exist within a abstract class. They can only be marked as
    // protected or public as they need to be accessible to any
    // inherited classes
    protected abstract int GetId();
    protected abstract string GetPersonType();

    // Start is called before the first frame update
    void Start()
    {
        PrintMessage();
    }

    protected void PrintMessage() => Debug.Log($"{GetPersonType()} ID: {GetId()}");
}
