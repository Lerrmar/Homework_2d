using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]

public class VolumeChange : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private float _upVolumeSound;
    [SerializeField]
    private float _downVolumeSound;
    [SerializeField]
    private float _durationSound;


    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void TurnOnSiren()
    {
        _audioSource.Play();
        _audioSource.DOFade(_upVolumeSound, _durationSound);
    }

    public void TurnOffSiren()
    {
        _audioSource.DOFade(_downVolumeSound, _durationSound);
        if (_audioSource.volume == _downVolumeSound)
        {
            _audioSource.Stop();
        }
    }
}
