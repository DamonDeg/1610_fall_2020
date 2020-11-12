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

    public weapons currentWeapon = weapons.sword;

    public void useWeapon()
    {
        switch (currentWeapon)
        {
            case weapons.sword:
                break;
            case weapons.axe:
                break;
            case weapons.sheild:
                break;
            case weapons.locket:
                break;
            case weapons.spoon:
                break;
            case weapons.acid:
                break;
            case weapons.grassClump:
                break;
            case weapons.h:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

}