using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform Anchor;

    private void Start()
    {
        Anchor.parent = transform.parent;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.transform.parent = Anchor;
        }
    }
    private void LateUpdate()
    {
        Anchor.position = transform.position;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.transform.parent = GameManager.instance.transform.parent;
        }
    }
}
