using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public void UpdateValue(int number)
    {

        value+=number;
        Debug.Log(value);

    }
    
    public void updateBar(Image bar)
    {
        bar.fillAmount = value;
    }
}
