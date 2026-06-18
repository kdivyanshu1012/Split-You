using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    public void playButton()
    {
        SceneManager.LoadSceneAsync("Level Select");
    }

    public void settingsButton()
    {
        SceneManager.LoadSceneAsync("Settings Menu");
    }

    public void exitButton()
    {
        Application.Quit();
    }
}
