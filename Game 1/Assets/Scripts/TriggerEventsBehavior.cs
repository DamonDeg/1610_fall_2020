using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {

        triggerEnterEvent.Invoke();

    }
}
