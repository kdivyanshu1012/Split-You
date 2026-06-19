using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    
    public void level1()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level 1");
    }
    public void level2()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level 2");
    }
    public void level3()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level 3");
    }
    public void level4()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level 4");
    }
    public void level5()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level 5");
    }
    public void level6()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level 6");
    }
    public void exit()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
