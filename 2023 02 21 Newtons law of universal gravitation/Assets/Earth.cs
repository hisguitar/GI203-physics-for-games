using UnityEngine;

public class Earth : MonoBehaviour
{
    private float _gravity = -9.81f; // <-- Global gravitational constant
    private float _speed = 50f;

    public void EarthAttract(Transform myBird)
    {
        // The normalized causes Vector3 to become a single value.
        Vector3 earthDirection = (myBird.position - transform.position).normalized;
        
        Vector3 birdDirection = myBird.up; // or (0, 1, 0)

        myBird.GetComponent<Rigidbody>().AddForce(earthDirection * _gravity);

        // Rotation of Bird
        Quaternion birdRotation = Quaternion.FromToRotation(birdDirection, earthDirection) * myBird.rotation;

        // Lerp is smooth movement
        myBird.rotation = Quaternion.Slerp(myBird.rotation, birdRotation, _speed * Time.deltaTime);
    }
}