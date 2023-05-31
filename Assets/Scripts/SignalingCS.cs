using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class SignalingCS : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _audioSource.Play();
            _audioSource.DOFade(1, 3);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _audioSource.DOFade(0, 3);
            if (_audioSource.volume == 0)
            {
                _audioSource.Stop();
            }
        }
    }
}
