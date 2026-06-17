using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public Animator transitions;
    

    public void LoadScene(string sceneName)
    {
        
            StartCoroutine(TransitionCoroutine(sceneName));
        
    }

    public IEnumerator TransitionCoroutine(string sceneName)
    {
        // 1. Play the 'Fade Out' (Start)
        transitions.SetTrigger("Start");

        // 2. Start loading in the background
        AsyncOperation loadScene = SceneManager.LoadSceneAsync(sceneName);
        loadScene.allowSceneActivation = false;

        // 3. Wait exactly 1 second (your animation length)
        // This ensures the screen is 100% black before we even check the load
        float timer = 0f;
        while (timer < 1f)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        // 4. Wait for the scene data to finish loading (hit the 0.9 cap)
        while (loadScene.progress < 0.9f)
        {
            yield return null;
        }

        // 5. ACTIVATE
        // Since the screen is fully black, the switch is invisible.
        loadScene.allowSceneActivation = true;

    }
}
