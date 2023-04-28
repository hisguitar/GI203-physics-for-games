using UnityEngine;

public class PositionTracking : MonoBehaviour
{
    public GameObject target;
    private void LateUpdate()
    {
        gameObject.transform.position = target.transform.position;
    }
}