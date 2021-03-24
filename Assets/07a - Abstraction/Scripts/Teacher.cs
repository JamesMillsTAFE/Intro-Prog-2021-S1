using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher : Person
{
    protected override int GetId() => Random.Range(1, 10);

    protected override string GetPersonType() => "Teacher";
}
