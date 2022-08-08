using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 MoveDir, float speed)
    {
        rb.AddForce(MoveDir * speed * Time.deltaTime);
    }
}
