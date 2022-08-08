using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    [SerializeField] private Transform player;
    [SerializeField] private Vector3 Offset;
    [SerializeField] private float dampsmooth;

    private Transform target;

    private void Start()
    {
        target = new GameObject().transform;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, dampsmooth * Time.deltaTime);
    }

    private void LateUpdate()
    {
        target.position = player.position + Offset;
    }
}
