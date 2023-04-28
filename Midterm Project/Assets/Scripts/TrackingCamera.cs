using UnityEngine;

public class TrackingCamera : MonoBehaviour
{
    public Transform playerTransform; // Reference to the player's transform
    public float smoothness = 3f; // How smoothly the camera should follow the player
    public float distance = 18f; // How far away the camera should be from the player

    void LateUpdate()
    {
        if (playerTransform == null) return; // Make sure the player transform is not null

        // Calculate the desired position and rotation of the camera
        Vector3 targetPosition = playerTransform.position + new Vector3(0f, 15f, -distance);
        Quaternion targetRotation = Quaternion.Euler(35f, 0f, 0f);

        // Smoothly move the camera towards the desired position and rotation
        transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition, smoothness * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, targetRotation, smoothness * Time.deltaTime);
    }
}