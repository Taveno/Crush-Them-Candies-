using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
  public Slider volumeSlider;
  public AudioSource audioSource;

  private const string VolumeKey = "GameVolume";

  void Start()
  {
    float savedVolume = PlayerPrefs.GetFloat(VolumeKey, 1f);
    
    volumeSlider.value = savedVolume;
    AudioListener.volume = savedVolume;
    
    volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
  }

  void OnVolumeChanged(float volume)
  {
    AudioListener.volume = volume;
    
    PlayerPrefs.SetFloat(VolumeKey, volume);
    PlayerPrefs.Save();
  }
}