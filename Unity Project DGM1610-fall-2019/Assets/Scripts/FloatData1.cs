
using System.Collections.Generic;
using UnityEngine;


    [CreateAssetMenu]
    
    
    
public class FloatData1 : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }
}
