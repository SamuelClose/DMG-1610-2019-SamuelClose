
using UnityEngine;

public class PlayerDisplay : MonoBehaviour
{
    public Stats stat;
    public  int playerHealth;
    public float playerMagic;
    public string playerName;
    public WeaponData weapon;
    public ClothesData shirt;
    public ClothesData pants;
    private void Awake()
    {
        playerHealth = stat.health;
        playerMagic = stat.magic;
        playerName = stat.name;
        weapon = stat.weapons;
        shirt = stat.shirt;
        pants = stat.pants;
    }
}
