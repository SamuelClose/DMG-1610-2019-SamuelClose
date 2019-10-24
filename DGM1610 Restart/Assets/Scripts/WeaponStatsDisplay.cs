using UnityEngine;
public class WeaponStatsDisplay : MonoBehaviour
{
    public WeaponData stats;
    public float range;
    public int weaponDamage;
    public string type;
    public string rarity;
    private void Start()
    {
        range = stats.maxRange;
        weaponDamage = stats.damage;
        type = stats.typeOf;
        rarity = stats.rarityScore;
        stats.SpawnItem();
    }
}
