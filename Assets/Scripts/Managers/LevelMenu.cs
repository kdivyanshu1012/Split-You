using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    
    public void level1()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
    public void level2()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }
    public void level3()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }
    public void level4()
    {
        SceneManager.LoadSceneAsync("Level 4");
    }
    public void level5()
    {
        SceneManager.LoadSceneAsync("Level 5");
    }
    public void level6()
    {
        SceneManager.LoadSceneAsync("Level 6");
    }
    public void exit()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
