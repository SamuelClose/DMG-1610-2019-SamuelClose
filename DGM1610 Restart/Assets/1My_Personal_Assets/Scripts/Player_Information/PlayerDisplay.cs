
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public Stats stat;
    public float playerHealth;
    public float playerMagic;
    public float playerMaxHealth;
    public string playerName;
    public WeaponData weapon;
    public ClothesData shirt;
    public ClothesData pants;
    
    
   
    
    private void Awake()
    {
       
        playerHealth = stat.health;
        playerMagic = stat.magic;
        playerMaxHealth = stat.maxHealth;
        playerName = stat.name;
        weapon = stat.weapons;
        shirt = stat.shirt;
        pants = stat.pants;
    }
}
