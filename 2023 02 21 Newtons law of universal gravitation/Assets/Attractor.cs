using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    private float G = 6.674f; // <-- Global gravitational constant
    public Rigidbody rb;
    public static List<Attractor> myAttractor;

    void FunctionAttract(Attractor objectToAttract)
    {
        // Mass(m1,m2)
        Rigidbody rbAttractor = objectToAttract.rb;

        // The direction of the star
        Vector3 direction = rb.position - rbAttractor.position;
        // The magnitude causes Vector3 to become a single value.
        float distance = direction.magnitude;

        // F = G(m1 * m2)/r^2 (The force that two stars act on each other)
        float forceMagnitude = G * (rb.mass * rbAttractor.mass) / Mathf.Pow(distance, 2);
        
        Vector3 force = direction.normalized * forceMagnitude;
        
        rbAttractor.AddForce(force);
    }

    void FixedUpdate()
    {
        foreach (Attractor thisAttractor in myAttractor)
        {
            if (thisAttractor != this)
            {
                FunctionAttract(thisAttractor);
            }
        }
    }

    private void OnEnable()
    {
        // If stars are disabled
        if (myAttractor == null)
        {
            // Find the next star
            myAttractor = new List<Attractor>();
        }
        // Add this star as an attractive star
        myAttractor.Add(this);
    }
}