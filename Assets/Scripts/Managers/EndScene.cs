using UnityEngine;
using UnityEngine.SceneManagement;
public class EndScene : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu ");
    }
}
