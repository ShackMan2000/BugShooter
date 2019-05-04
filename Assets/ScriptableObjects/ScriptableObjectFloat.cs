using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ScriptableObjectFloat : ScriptableObject
{
   public float currentValue, maxValue;

    public static implicit operator float(ScriptableObjectFloat v)
    {
        throw new NotImplementedException();
    }
}
