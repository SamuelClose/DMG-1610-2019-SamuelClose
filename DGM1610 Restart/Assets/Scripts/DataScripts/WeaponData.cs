using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class WeaponData : GameArtData
{
    public int damage;

    public float maxRange;

    public string rarityScore;

    public string typeOf;

    public void SpawnItem()
    {
        var newWeapon = Instantiate(prefab);
        var newSprite = newWeapon.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
    }

}
