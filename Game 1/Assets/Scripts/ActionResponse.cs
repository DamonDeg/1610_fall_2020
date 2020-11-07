using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionResponse : MonoBehaviour
{
    public GameAction actionObj;
    public UnityEvent handlerEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        actionObj.action += Handle;
    }

    private void Handle()
    {
        handlerEvent.Invoke();
    }
}
