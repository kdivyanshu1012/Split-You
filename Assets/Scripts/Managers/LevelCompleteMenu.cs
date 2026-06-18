using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelCompleteMenu : MonoBehaviour
{
    [SerializeField] private int levels = 6;
    
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
            SceneManager.LoadSceneAsync("End Scene");
        }

    }

    public void levelGrid()
    {
        SceneManager.LoadSceneAsync("Level Select");
    }

    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
