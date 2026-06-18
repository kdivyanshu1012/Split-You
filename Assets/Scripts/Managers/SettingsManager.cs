using UnityEngine;
using UnityEngine.SceneManagement;


public class InstructionsManager : MonoBehaviour
{
    
    public void HomeButton()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
