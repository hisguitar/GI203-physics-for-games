using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddF : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(100, 0, 0);
        } 
    }
}
