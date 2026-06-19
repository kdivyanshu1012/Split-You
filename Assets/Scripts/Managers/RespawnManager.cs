using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [Header("References")]
    public GameObject playerPrefab;
    public Transform spawnPoint;
    public CloneManager cloneManager;

    private GameObject currentPlayer;

    void Start()
    {
        SpawnPlayer();
        if (cloneManager != null)
        {
            cloneManager.player = currentPlayer.transform;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            AudioManager.Instance.PlaySFX(12);
            Invoke("Respawn",0.2f);
        }
    }

   
    void SpawnPlayer()
    {
        currentPlayer = Instantiate(
            playerPrefab,
            spawnPoint.position,
            Quaternion.identity
        );
    }

    [System.Obsolete]
    public void Respawn()
    {
        // Destroy player
        if (currentPlayer != null)
        {
            Destroy(currentPlayer);
        }

        
        if (cloneManager != null)
        {
            cloneManager.DestroyClone();
        }

        // Spawn new player
        SpawnPlayer();
        

        if (cloneManager != null)
        {

            cloneManager.player = currentPlayer.transform;
        }

    }

    public GameObject GetPlayer()
    {
        return currentPlayer;
    }
}