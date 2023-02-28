using UnityEngine;

public class AngularVelocity : MonoBehaviour
{
    public Vector3 myAngularVelocity, myTorque;
    public Rigidbody rb;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            // Rotate object with angular velocity. (Rotate a bit when you stop using it.)
            rb.angularVelocity = myAngularVelocity;
        }
        else if (Input.GetKey(KeyCode.T))
        {
            // Rotate object with AddTorque (Immediately stop when not in use)
            rb.AddTorque(myTorque);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}