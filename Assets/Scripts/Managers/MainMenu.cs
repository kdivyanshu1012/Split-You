using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    public void playButton()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level Select");
    }

    public void settingsButton()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Settings Menu");
        
    }

    public void exitButton()
    {
        AudioManager.Instance.PlaySFX(4);
        Application.Quit();
    }
}
