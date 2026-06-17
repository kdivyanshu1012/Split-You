using UnityEngine;


public class MainMenu : MonoBehaviour
{
    [SerializeField] private TransitionManager transitionManager;
    public void playButton()
    {
        transitionManager.LoadScene("Level Select");
    }

    public void instructionsButton()
    {
        transitionManager.LoadScene("Instructions Menu");
    }

    public void exitButton()
    {
        Application.Quit();
    }
}
