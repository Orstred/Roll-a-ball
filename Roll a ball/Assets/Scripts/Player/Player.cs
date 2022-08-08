using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(PlayerMotor))]
public class Player : MonoBehaviour
{

    [SerializeField] private float speed;

    private PlayerMotor motor;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3( hAxis, 0 , vAxis);

        motor.Move(direction, speed);
    }
}
