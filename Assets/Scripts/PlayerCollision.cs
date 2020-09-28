using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    public delegate void switchHit();
    public static event switchHit OnSwitchHit;

    public delegate void TrapHit();
    public static event TrapHit OnTrapHit;


    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obs")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "switch")
        {
            OnSwitchHit?.Invoke();
        }

        if (other.tag == "trap")
        {
            OnTrapHit?.Invoke();
        }
    }
}


