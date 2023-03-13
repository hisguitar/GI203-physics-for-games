using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class AirPlane : MonoBehaviour
{
    public Rigidbody rb;
    public float enginPowerThrust, liftBooster, drag, angularDrag;

    private void FixedUpdate()
    {
        // Step 1. Add Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.forward * enginPowerThrust); // forward = move z axis +1
        }
        
        // Step 2. Lift
        Vector3 lift = Vector3.Project(rb.velocity, transform.forward);
        rb.AddForce(transform.up * (lift.magnitude * liftBooster));
        
        // Step 3. Drag
        rb.drag = rb.velocity.magnitude * drag;
        rb.angularDrag = rb.velocity.magnitude * angularDrag;
        
        // Step 4. Control
        // Step 4.1 Left - Right
        rb.AddTorque(Input.GetAxis("Horizontal") * transform.forward * -1);
        // Step 4.2 Up - Down
        rb.AddForce(Input.GetAxis("Vertical")* transform.right);
    }
}