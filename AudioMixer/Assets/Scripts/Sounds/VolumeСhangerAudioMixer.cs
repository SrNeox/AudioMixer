using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChangerAudioMixer : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private ToggleSound _toggleSound;

    private const float MinValue = 0.0001f;
    private const float DecibelConversion = 20f;

    public void ChangeVolume(Slider slider)
    {
        if (_toggleSound.IsSoundOn)
        {
            float volume = Mathf.Max(slider.value, MinValue);
            string volumeGroup = slider.name;

            Debug.Log(slider.name);
            _audioMixer.SetFloat(volumeGroup, Mathf.Log10(volume) * DecibelConversion);
        }
    }
}
