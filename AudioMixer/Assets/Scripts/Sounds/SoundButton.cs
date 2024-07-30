using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;

    public void PlaySound()
    {
        _audioSource.Play();
    }
}
