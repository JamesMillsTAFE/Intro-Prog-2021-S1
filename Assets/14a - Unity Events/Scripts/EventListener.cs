using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    // The event listener. A listener is a function that is waiting
    // to be called in a 'batch' by the event publisher. A listener
    // is also known as a 'subscriber'. #SubToPewds
    public void OnDeath(int _someRandomNumber)
    {
        Debug.Log(_someRandomNumber);
    }

    public void OnDeathSqrd(int _number)
    {
        Debug.LogError($"Death Squared = {_number * _number}");
    }
}
