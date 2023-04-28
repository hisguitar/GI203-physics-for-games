using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Volleyball : MonoBehaviour
{
    public AudioClip teleportSound;
    public GameObject playerPosition;
    public GameObject floatingTextPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Bounce();
            
            // Score here!
            Debug.Log("+100 Points");
            if (floatingTextPrefab)
            {
                ShowFloatingText();
            }
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Bounce();
        }
    }

    private void Bounce()
    {
        if (teleportSound != null)
        {
            AudioSource.PlayClipAtPoint(teleportSound, Camera.main!.transform.position);
        }
        
        transform.position = playerPosition.transform.position + new Vector3(Random.Range(-5, 5), 10, Random.Range(-5, 5));
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    private void ShowFloatingText()
    { 
        Instantiate(floatingTextPrefab, playerPosition.transform.position, Quaternion.identity, playerPosition.transform);
    }
}