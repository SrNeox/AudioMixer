using UnityEngine;
using UnityEngine.Audio;

public class VolumeСhangerAudioMixer : MonoBehaviour
{
    [SerializeField] private string _nameGroupAudioMixer;
    [SerializeField] private AudioMixer _audioMixer;

    private float _minValue = 0.0001f;

    public void ChangeVolume(float volume)
    {
        volume = Mathf.Max(volume, _minValue);
        _audioMixer.SetFloat(_nameGroupAudioMixer, Mathf.Log10(volume) * 20);
    }
}
