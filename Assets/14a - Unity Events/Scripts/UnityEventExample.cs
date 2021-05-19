using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
    // Unity events MUST be serializable in order to show up in the inspector
    // they will still work without being serialized, but what's the point of them
    // if they don't show up?
    [System.Serializable]
    public class DeathEvent : UnityEvent<int> { }

    // The standard within unity is to make the instance of the event
    // private and then make a readonly property to access it
    public DeathEvent OnDeath => onDeath;
    // Even though we have created the type of event, we haven't created
    // an instance of the event itself, so we are doing that here.
    [SerializeField] private DeathEvent onDeath = new DeathEvent();

    public void Die()
    {
        // Run/'Raise' the death event. We add ? to make sure it is not null
        onDeath?.Invoke(Random.Range(0, 10));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Die();
        }
    }
}
