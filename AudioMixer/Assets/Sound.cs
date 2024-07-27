using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private AudioSource _button1Sound;
    [SerializeField] private AudioSource _button2Sound;
    [SerializeField] private AudioSource _button3Sound;
    [SerializeField] private AudioSource _backgroundMusic;
    [SerializeField] private Button _soundToggleButton;
    [SerializeField] private TextMeshProUGUI _textOnOff;

    private bool isSoundOn = true;
    private float _MinValue = 0.0001f;

    public void SetMasterVolum(float volume)
    {
        SetVolume(volume, "MasterVolume");
    }

    public void SetButtonVolum(float volume)
    {
        SetVolume(volume, "ButtonsVolume");
    }

    public void SetMusicVolum(float volume)
    {
        SetVolume(volume, "MusicVolume");
    }

    public void ToggleSound()
    {
        isSoundOn = !isSoundOn;
        AudioListener.volume = isSoundOn ? 1 : 0;
        _textOnOff.text = isSoundOn ? "Выкл звук" : "Вкл звук";
    }

    public void PlayButton1Sound()
    {
        _button1Sound.Play();
    }

    public void PlayButton2Sound()
    {
        _button2Sound.Play();
    }

    public void PlayButton3Sound()
    {
        _button3Sound.Play();
    }
    
    private void SetVolume(float volume, string nameGroupMixer)
    {
        volume = Mathf.Max(volume, _MinValue);
        _audioMixer.SetFloat(nameGroupMixer , Mathf.Log10(volume) * 20);
    }
}