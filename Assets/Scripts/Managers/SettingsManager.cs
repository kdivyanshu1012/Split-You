using UnityEngine;
using UnityEngine.SceneManagement;


public class InstructionsManager : MonoBehaviour
{
    
    public void HomeButton()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
