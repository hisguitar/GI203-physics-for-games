using UnityEngine;

public class MyRaycast : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        Vector3 origin = transform.position;
        // Direction in short style
        Vector3 direction = -transform.up; // or.. Vector3 direction = new Vector3(0, 1, 0);
        
        // Raycast(1)
        Debug.DrawRay(origin, direction * 3, Color.green);

        // Raycast(2)
        Ray ray = new Ray(origin, direction);
        // If Raycast(2) collide with <any object>
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 3))
        {
            // Display name of the hit object to the console
            if (hitInfo.collider.GetComponent<Renderer>().material.color != Color.yellow)
            {
                Debug.Log(hitInfo.collider.gameObject.name);
            }
            
            // Change <any object> to yellow
            hitInfo.collider.GetComponent<Renderer>().material.color = Color.yellow;
            
            // Destroy rigidbody of this object
            Destroy(GetComponent<Rigidbody>());
            
            // Add torque to "Sphere"
            GameObject.Find("Sphere").GetComponent<Rigidbody>().AddTorque(0, 100, 0);
        }
    }
}