using UnityEngine;

public class Magnus : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 angularV, velocity;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.angularVelocity = angularV;
            rb.velocity = velocity;
        }
        rb.AddForce(Vector3.Cross(rb.angularVelocity, rb.velocity));
    }
}