using UnityEngine;

public class FloatingText : MonoBehaviour
{
    public float destroyTime = 1.0f;
    private void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}