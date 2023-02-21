using UnityEngine;

public class Bird : MonoBehaviour
{
    public Earth mEarth;
    public Vector3 birdForce;
    private Transform _tBird; // Position, Rotation, Scale of Bird
    private Rigidbody _rbBird; // Rigidbody of Bird

    // Start is called before the first frame update
    private void Start()
    {
        _rbBird = GetComponent<Rigidbody>();
        _rbBird.constraints = RigidbodyConstraints.FreezeRotation;

        _tBird = transform;
        
        _rbBird.AddForce(birdForce);
    }
    
    private void FixedUpdate()
    {
       mEarth.EarthAttract(_tBird); 
    }
}