using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    public float speed = 12f;
    public float groundLevel = 1f;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Keep input button to "move variable"
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        
        // Movement and Rotation
        if (move != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(move);
        }
        _characterController.Move(move * (Time.deltaTime * speed));

        // Keep character on ground level
        if (transform.position.y > groundLevel)
        {
            gameObject.transform.position = new Vector3(transform.position.x, groundLevel, transform.position.z);
        }
    }
}