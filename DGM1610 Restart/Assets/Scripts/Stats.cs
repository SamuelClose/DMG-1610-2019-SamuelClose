using UnityEngine;
[CreateAssetMenu(fileName = "New Stats", menuName = "Stat")]
public class Stats : GameArtData
{
    public new string name;
    public int health;
    public int magic;
    public int damage;
    public int maxHealth;
    public void SpawnPlayer()
             {
                 var newPlayer = Instantiate(prefab);
                 var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
                 newSprite.sprite = sprite;
                 newSprite.color = color;
             }


}
