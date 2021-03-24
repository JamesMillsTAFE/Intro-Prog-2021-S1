using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Person
{
    // Lambdas are just one line functions that can re-route the code to another
    // piece of data. In this case it is the same as just returning the values.
    protected override int GetId() => Random.Range(1000000, 9000000);

    protected override string GetPersonType() => "Student";
}
