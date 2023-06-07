using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private float _durationMoveToPointPlayer = 3;
    [SerializeField]
    private float _durationMoveToPointCamera = 10;
    [SerializeField]
    private const string _movementKey = "Fire1";

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetButtonDown(_movementKey))
        {
            Vector3 scrinMousPosition = Input.mousePosition;
            Vector3 worldMousPosition = _camera.ScreenToWorldPoint(scrinMousPosition);
            transform.DOMove(worldMousPosition, _durationMoveToPointPlayer);
            _camera.transform.DOMove(worldMousPosition, _durationMoveToPointCamera);
        }

    }
}
