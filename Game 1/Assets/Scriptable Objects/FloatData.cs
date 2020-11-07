using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;
    public void UpdateValue(float number)
    {

        value+=number;
        Debug.Log(value);

    }
    
    public void UpdateBar(Image bar)
    {
        bar.fillAmount = value;
    }
}
