using UnityEngine;

public class MyRaycast : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 origin = transform.position;
        // Vector3 direction = new Vector3(0, 1, 0); // Direction in long style
        Vector3 direction = -transform.up; // Direction in short style
        
        Debug.DrawRay(origin, direction * 3, Color.green); // Raycast(1)

        Ray ray = new Ray(origin, direction); // Raycast(2)
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 3)) // If Raycast(2) collide with <any object>
        {
            hitInfo.collider.GetComponent<Renderer>().material.color = Color.yellow; // Change <any object> to yellow
            Destroy(GetComponent<Rigidbody>()); // Destroy rigidbody of this object
            GameObject.Find("Sphere").GetComponent<Rigidbody>().AddTorque(0, 100, 0); // Add torque to "Sphere"
        }
    }
}