using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 scrinMousPosition = Input.mousePosition;
            Vector3 worldMousPosition = _camera.ScreenToWorldPoint(scrinMousPosition);
            transform.DOMove(worldMousPosition, 3);
            _camera.transform.DOMove(worldMousPosition, 10);
        }

    }
}
