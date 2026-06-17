using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public Door playerDoor;
    public Door cloneDoor;
    [SerializeField] private Animator doorAnim;
    [SerializeField] private Animator cloneAnim;
    [SerializeField] private float duration = 2f;
    [SerializeField] private TransitionManager transitionManager;
    
    



    private bool levelCompleted = false;
    void Update()
    {
        if (!levelCompleted && playerDoor.IsActivated() && cloneDoor.IsActivated() && Input.GetKey(KeyCode.W))
        {
            CompleteLevel();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transitionManager.LoadScene("Level Complete");
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
        yield return new WaitForSeconds(duration);
        transitionManager.LoadScene("Level Complete");
    }

    
}

    


