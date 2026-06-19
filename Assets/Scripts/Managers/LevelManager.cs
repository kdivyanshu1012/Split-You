using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public Door playerDoor;
    public Door cloneDoor;
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Animator cloneAnim;
    [SerializeField] private float duration = 0.4f;
    
    
    



    private bool levelCompleted = false;
    void Update()
    {
        if (!levelCompleted && playerDoor.IsActivated() && cloneDoor.IsActivated() && Input.GetKey(KeyCode.W))
        {
            CompleteLevel();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("Level Complete");
        }
        
    }

    void CompleteLevel()
    {
        levelCompleted = true;

        LevelCompleteMenu.lastLevelIndex = SceneManager.GetActiveScene().buildIndex;

        StartCoroutine(LevelCompleteRoutine());
        
    }

    IEnumerator LevelCompleteRoutine()
    {
        
        doorAnim.SetBool("levelCompleted", true);
        cloneAnim.SetBool("levelCompleted", true);
        AudioManager.Instance.PlaySFX(2);
        yield return new WaitForSeconds(duration);
        SceneManager.LoadSceneAsync("Level Complete");
    }

    
}

    


