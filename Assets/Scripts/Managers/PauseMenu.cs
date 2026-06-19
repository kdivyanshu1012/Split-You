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
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Level Select");
        Resume();
    }

    [System.Obsolete]
    public void Restart()
    {
        AudioManager.Instance.PlaySFX(12);
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
        AudioManager.Instance.PlaySFX(4);
        isPaused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
}
