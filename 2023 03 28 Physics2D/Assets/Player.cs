using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float force, torque;

    void Update()
    {
        /* Input.GetMouseButtonDown(0) is Left click
         Input.GetMouseButtonDown(1) is Right click */
        
        if (Input.GetMouseButtonDown(0))
        {
            rb2d.AddForce(new Vector2(force, force), ForceMode2D.Impulse);
        }

        if (Input.GetMouseButtonDown(1))
        {
            //rb2d.AddTorque(torque);
            rb2d.AddForce(new Vector2(-force, force), ForceMode2D.Impulse);

        }
    }
}