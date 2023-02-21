using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Earth mEarth;
    private Transform tBird; // Position, Rotation, Scale of Bird
    private Rigidbody rbBird; // Rigidbody of Bird
    public Vector3 birdForce;
    
    // Start is called before the first frame update
    void Start()
    {
        rbBird = GetComponent<Rigidbody>();
        rbBird.constraints = RigidbodyConstraints.FreezeRotation;

        tBird = transform;
        
        rbBird.AddForce(birdForce);
    }
    
    void FixedUpdate()
    {
       mEarth.eAttract(tBird); 
    }
}