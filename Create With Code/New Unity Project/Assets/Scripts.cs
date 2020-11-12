using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Scripts : ScriptableObject
{


    public enum weapons
    {
        sword,
        axe,
        sheild,
        locket,
        spoon,
        acid,
        grassClump,
        h
    }

    public void useWeapon()
    {
        switch (weapons)
        {
            case weapons.acid:
                break;
            case weapons.acid:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

}