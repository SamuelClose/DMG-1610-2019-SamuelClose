using UnityEngine;
[CreateAssetMenu(fileName = "New Stats", menuName = "Stat")]
public class Stats : GameArtData
{
    public new string name;
    public int health;
    public int magic;
    public WeaponData weapons;
    public ClothesData shirt;
    public ClothesData pants;
}
