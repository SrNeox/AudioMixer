using TMPro;
using UnityEngine;

public class TongleSound : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textOnOff;

    private bool _isSoundOn = true;

    public void ToggleSound()
    {
        _isSoundOn = !_isSoundOn;
        AudioListener.volume = _isSoundOn ? 1 : 0;
        _textOnOff.text = _isSoundOn ? "Выкл звук" : "Вкл звук";
    }
}