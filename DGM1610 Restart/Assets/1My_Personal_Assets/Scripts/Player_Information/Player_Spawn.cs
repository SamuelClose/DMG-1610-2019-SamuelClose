using UnityEngine;
public class Player_Spawn : MonoBehaviour
{
    public PlayerDisplay info;
    public PlayerMovement move;
    public bool isDead;
    public float health;
    public GameObject newPlayer;
    private void Awake()
    {
        info = GetComponent<PlayerDisplay>();
        move = GetComponent<PlayerMovement>();
    }
    private void FixedUpdate()
    {
        if (info.playerHealth <= 0)
        {
            isDead = true;
        }

        Respawn();
    }
    private void SpawnPlayer()
    {
        if (move.resTimer < 5)
        {
            newPlayer = Instantiate(newPlayer);
        }

        
    }
    private void Respawn()
    {
        if (isDead)
        {
            move.resTimer -= Time.deltaTime;
            SpawnPlayer();
        }
    }
    
}
