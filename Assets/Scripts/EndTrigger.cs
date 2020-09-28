using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player") 
        {
            gameManager.CompleteLevel();
        }
    }
}
