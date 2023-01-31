using UnityEngine;

public class RotateCube : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        Vector3 origin = transform.position;
        // Direction in short style//
        Vector3 direction = -transform.up; // or... Vector3 direction = new Vector3(0, 1, 0);
        
        // Raycast(1)
        Debug.DrawRay(origin, direction * 3, Color.green);

        // Raycast(2)
        Ray ray = new Ray(origin, direction);
        // If Raycast(2) collide with <any object>
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 3))
        {
            // Change <any object> to yellow
            hitInfo.collider.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}