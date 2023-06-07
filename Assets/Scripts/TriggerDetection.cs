using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TriggerDetection : MonoBehaviour
{
    [SerializeField]
    private VolumeChange _volumeChange;

    private void Start()
    {
        _volumeChange = FindObjectOfType<VolumeChange>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMove>(out PlayerMove player))
        {
            _volumeChange.TurnOnSiren();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMove>(out PlayerMove player))
        {
            _volumeChange.TurnOffSiren();
        }
    }
}
