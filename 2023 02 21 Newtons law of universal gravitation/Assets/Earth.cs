using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    private float gravity = -9.81f; // <-- Global gravitational constant
    private float speed = 50f;

    public void eAttract(Transform myBird)
    {
        // The normalized causes Vector3 to become a single value.
        Vector3 earthDirection = (myBird.position - transform.position.normalized);

        // or (0, 1, 0)
        Vector3 birdDirection = myBird.up;

        myBird.GetComponent<Rigidbody>().AddForce(earthDirection * gravity);

        // Rotation of Bird
        Quaternion birdRotation = Quaternion.FromToRotation(birdDirection, earthDirection) * myBird.rotation;

        // Lerp is smooth movement
        myBird.rotation = Quaternion.Slerp(myBird.rotation, birdRotation, speed * Time.deltaTime);
    }
}
