using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SettingsManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private float mixerMultiplier = 25;
    [Header("Sfx Settings")]
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private string sfxParameter;
    [Header("Bgm Settings")]
    [SerializeField] private Slider bgmSlider;
    [SerializeField] private string bgmParameter;

    public void HomeButton()
    {
        AudioManager.Instance.PlaySFX(4);
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void SfxSliderFunc(float value)
    {
        float newValue = Mathf.Log10(value) * mixerMultiplier;
        audioMixer.SetFloat(sfxParameter, newValue);
    }

    public void BgmSliderFunc(float value)
    {
        float newValue = Mathf.Log10(value) * mixerMultiplier;
        audioMixer.SetFloat(bgmParameter, newValue);
    }
    
}
