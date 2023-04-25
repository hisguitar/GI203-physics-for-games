using UnityEngine;

public class DestroyInvisible : MonoBehaviour
{
    // Destroy this game object when it disappears from the screen
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}