using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "New Stats", menuName = "Stat")]
public class Stats : ScriptableObject
{
    public new string name;
    
    public int health;

    public int magic;

    public int damage;

    public int maxHealth;


}
