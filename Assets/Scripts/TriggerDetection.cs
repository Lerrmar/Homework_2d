using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriggerDetection : MonoBehaviour
{

    [SerializeField]
    private string _targetTag = "Player";
    [SerializeField]
    private VolumeChange _volumeChange;

    private void Start()
    {
        _volumeChange = FindObjectOfType<VolumeChange>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_targetTag))
        {
            _volumeChange.TurnOnSiren();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_targetTag))
        {
            _volumeChange.TurnOffSiren();
        }
    }
}
