using UnityEngine;

public class CalculateTension : MonoBehaviour
{
    [SerializeField] private float mass, acceleration, tension;
    
    // Start is called before the first frame update
    private void Start()
    {
        mass = GetComponent<Rigidbody>().mass;
    }

    // Update is called once per frame
    //private void Update()
    private void FixedUpdate()
    {
        //tension = (mass * -Physics.gravity.y) + (mass * acceleration);
        tension = mass * (-Physics.gravity.y + acceleration);
        GetComponent<Rigidbody>().AddForce(0, tension, 0);
    }
} // CalculateTension
