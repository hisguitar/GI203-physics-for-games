using UnityEngine;

public class MyInertia : MonoBehaviour
{
    public Rigidbody rb;
    
    void FixedUpdate()
    {
        /*Input.GetAxis("...") is get the button to move in the axis.
        Horizontal or Vertical ..*/
        transform.localScale += new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        rb.angularVelocity = rb.inertiaTensor;
        
        /*The inertia increases with size..*/
        print("Inertia : " + rb.inertiaTensor);
    }
}