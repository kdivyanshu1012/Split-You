using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelCompleteMenu : MonoBehaviour
{
    [SerializeField] private int levels = 6;
    [SerializeField] TransitionManager transitionManager;
    public static int lastLevelIndex;
    public void NextLevel()
    {
        int nextIndex = lastLevelIndex + 1;

        
        if (nextIndex < levels)
        {
            SceneManager.LoadSceneAsync(nextIndex);
        }
        else
        {
            transitionManager.LoadScene("End Scene");
        }

    }

    public void levelGrid()
    {
        transitionManager.LoadScene("Level Select");
    }

    public void MainMenu()
    {
        transitionManager.LoadScene("Main Menu");
    }
}
