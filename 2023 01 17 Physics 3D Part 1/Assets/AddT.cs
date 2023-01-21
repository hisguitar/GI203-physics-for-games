using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddT : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddTorque(0, 1, 0);
    }
}
