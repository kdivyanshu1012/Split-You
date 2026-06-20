using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelCompleteMenu : MonoBehaviour
{
    [SerializeField] private int levels = 16;
    
    public static int lastLevelIndex;
    public void NextLevel()
    {
        int nextIndex = lastLevelIndex + 1;

        
        if (nextIndex < levels)
        {
            AudioManager.Instance.PlaySFX(4);
            SceneManager.LoadSceneAsync(nextIndex);
        }
        else
        {
            AudioManager.Instance.PlaySFX(4);
            SceneManager.LoadSceneAsync("End Scene");
        }

    }

    public void levelGrid()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level Select");
    }

    public void MainMenu()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
