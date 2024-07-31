using UnityEngine;
using UnityEngine.Audio;

public class VolumeСhangerAudioMixer : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private TongleSound _tongleSound;

    private string _groupMasterVolume = "MasterVolume";
    private string _groupButtonsVolume = "ButtonsVolume";
    private string _groupMusicVolume = "MusicVolume";

    private float _minValue = 0.0001f;
    private float _decibelConversion = 20f;

    public void ChangeMasterVolume(float volume)
    {
        if (_tongleSound._isSoundOn != false)
        {
            volume = Mathf.Max(volume, _minValue);
            _audioMixer.SetFloat(_groupMasterVolume, Mathf.Log10(volume) * _decibelConversion);
        }
    }

    public void ChangeButtonsVolume(float volume)
    {
        if (_tongleSound._isSoundOn != false)
        {
            volume = Mathf.Max(volume, _minValue);
            _audioMixer.SetFloat(_groupButtonsVolume, Mathf.Log10(volume) * _decibelConversion);
        }
    }

    public void ChangeMusicVolume(float volume)
    {
        if (_tongleSound._isSoundOn != false)
        {
            volume = Mathf.Max(volume, _minValue);
            _audioMixer.SetFloat(_groupMusicVolume, Mathf.Log10(volume) * _decibelConversion);
        }
    }
}
