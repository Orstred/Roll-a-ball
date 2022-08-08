using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private float rotatingSpeed;

    private GameManager manager;
    private Transform _transform;

    private void Start()
    {
        _transform = transform;

        manager = GameManager.instance;

        manager.AddCoin();
    }

    private void Update()
    {
        _transform.rotation = RotateCoin();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            manager.PickupCoin(ObjToDestroy: gameObject);
        }
    }


    public Quaternion RotateCoin()
    {
        return Quaternion.Euler(90, transform.eulerAngles.y + rotatingSpeed * Time.deltaTime, 0);
    }
}
