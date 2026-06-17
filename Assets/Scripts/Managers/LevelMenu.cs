using UnityEngine;

public class LevelMenu : MonoBehaviour
{
    [SerializeField] private TransitionManager transitionManager;
    public void level1()
    {
        transitionManager.LoadScene("Level 1");
    }
    public void level2()
    {
        transitionManager.LoadScene("Level 2");
    }
    public void level3()
    {
        transitionManager.LoadScene("Level 3");
    }
    public void level4()
    {
        transitionManager.LoadScene("Level 4");
    }
    public void level5()
    {
        transitionManager.LoadScene("Level 5");
    }
    public void level6()
    {
        transitionManager.LoadScene("Level 6");
    }
    public void exit()
    {
        transitionManager.LoadScene("Main Menu");
    }
}
