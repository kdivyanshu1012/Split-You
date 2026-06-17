using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("Settings")]
    public bool isForClone = false; 

    private bool isActivated = false;

    
    public bool IsActivated()
    {
        return isActivated;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerMovement player = collision.GetComponent<playerMovement>();

        if (player == null) return;

        // Check correct entity
        if (player.isClone == isForClone)
        {
            isActivated = true;
            Debug.Log(gameObject.name + " activated");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerMovement player = collision.GetComponent<playerMovement>();

        if (player == null) return;

        if (player.isClone == isForClone)
        {
            isActivated = false;
            Debug.Log(gameObject.name + " deactivated");
        }
    }
}