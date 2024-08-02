using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleSound : MonoBehaviour
{
    private const string GroupMasterVolume = "MasterVolume";

    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private TextMeshProUGUI _textOnOff;
    [SerializeField] private Slider _sliderMasterVolume; 

    public bool IsSoundOn { get; private set; }


    private void Start()
    {
        IsSoundOn = true;
    }

    public void Toggle()
    {
        IsSoundOn = !IsSoundOn;

        if (IsSoundOn == false)
        {
            int volumeOff = -80;

            _audioMixer.SetFloat(GroupMasterVolume, volumeOff);
        }
        else
        {
            _audioMixer.SetFloat(GroupMasterVolume, _sliderMasterVolume.value);
        }

        _textOnOff.text = IsSoundOn ? "Выкл звук" : "Вкл звук";
    }


}