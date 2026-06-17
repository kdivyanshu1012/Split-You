using UnityEngine;

public class CloneManager : MonoBehaviour
{
    [Header("References")]
    public GameObject clonePrefab;
    public Transform player;

    [Header("Settings")]
    public KeyCode cloneKey = KeyCode.C;
    public Vector2 spawnOffset = new Vector2(0.2f, 0f);

    private GameObject cloneInstance;
    void Start()
    {
        if (player == null)
        {
            playerMovement foundPlayer = FindFirstObjectByType<playerMovement>();
            if (foundPlayer != null)
            {
                player = foundPlayer.transform;
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(cloneKey))
        {
            SpawnClone();
        }
    }
    public void SpawnClone()
    {
        if (cloneInstance != null)
            return;

        if (player == null)
        {
            playerMovement foundPlayer = FindFirstObjectByType<playerMovement>();

            if (foundPlayer != null)
            {
                player = foundPlayer.transform;
            }
        }

        if (clonePrefab == null || player == null)
        {
            Debug.LogWarning("CloneManager: Missing references!");
            return;
        }

        // Spawn at player position
        Vector3 spawnPos = player.position;

        cloneInstance = Instantiate(
            clonePrefab,
            spawnPos,
            Quaternion.identity
        );

        playerMovement cloneScript = cloneInstance.GetComponent<playerMovement>();

        if (cloneScript != null)
        {
            cloneScript.isClone = true;
        }
        else
        {
            Debug.LogWarning("CloneManager: PlayerController missing on clone!");
        }
    }

    [System.Obsolete]
    public void DestroyClone()
    {
        
        if (cloneInstance != null)
        {
            Destroy(cloneInstance);
            cloneInstance = null;
        }

        
        playerMovement[] allPlayers = FindObjectsOfType<playerMovement>();

        foreach (var p in allPlayers)
        {
            if (p.isClone)
            {
                Destroy(p.gameObject);
            }
        }
    }

}