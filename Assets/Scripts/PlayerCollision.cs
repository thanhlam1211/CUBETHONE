
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name); Express name of the whatever we hit
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            //Debug.Log("We hit the obtacle!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
