using UnityEngine;


public class InstructionsManager : MonoBehaviour
{
    [SerializeField] private TransitionManager transitionManager;
    public void HomeButton()
    {
        transitionManager.LoadScene("Main Menu");
    }
}
