using UnityEngine;

public class AddForceCube : MonoBehaviour
{
    [SerializeField] private float mass, acceleration, force;

    public void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * acceleration; // F = ma
        GetComponent<Rigidbody>().AddForce(force, force, 0);
    } // CalculateForce
    
    // 3 UI Button, Add acceleration
    public void A250()
    {
        acceleration = 250;
        CalculateForce();
    }
    public void A300()
    {
        acceleration = 300;
        CalculateForce();
    }
    public void A350()
    {
        acceleration = 350;
        CalculateForce();
    }
    
} // AddForceCube