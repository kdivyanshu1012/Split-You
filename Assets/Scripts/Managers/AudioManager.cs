using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Audio Source")]
    [SerializeField] private AudioSource[] sfx;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void PlaySFX(int sfxIndex)
    {
        if(sfxIndex >= sfx.Length)
        {
            return;
        }
        sfx[sfxIndex].Play();
    }

    public void StopSFX(int sfxIndex)
    {
        sfx[sfxIndex].Stop();

    }
}
