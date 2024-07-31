using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class TongleSound : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private TextMeshProUGUI _textOnOff;

    public bool _isSoundOn { get; private set; }


    private void Start()
    {
        _isSoundOn = true;
    }

    public void ToggleSound()
    {
        _isSoundOn = !_isSoundOn;

        if (_isSoundOn == false)
        {
            int volumeOff = -80;

            _audioMixer.SetFloat("MasterVolume", volumeOff);
        }
        else
        {
            int volumeDefault = 0;

            _audioMixer.SetFloat("MasterVolume", volumeDefault);
        }

        _textOnOff.text = _isSoundOn ? "Выкл звук" : "Вкл звук";
    }


}