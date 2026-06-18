using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    public void playButton()
    {
        SceneManager.LoadSceneAsync("Level Select");
    }

    public void instructionsButton()
    {
        SceneManager.LoadSceneAsync("Instructions Menu");
    }

    public void exitButton()
    {
        Application.Quit();
    }
}
