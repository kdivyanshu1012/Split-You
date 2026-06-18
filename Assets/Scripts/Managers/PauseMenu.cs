using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private RespawnManager respawnManager;
    
    private bool isPaused = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Paused();
        }
    }
    public void Paused()
    {
        if (isPaused)
        {
            isPaused = false;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }
    
    public void LevelSelect()
    {
        SceneManager.LoadSceneAsync("Level Select");
        Resume();
    }

    [System.Obsolete]
    public void Restart()
    {
        respawnManager.Respawn();
        Resume();
    }
    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    
    public void PauseButton()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
}
