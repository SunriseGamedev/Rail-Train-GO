using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float maxspeed = 7;
    float time;
    int printtime;
    private Rigidbody rb;
    private Transform Transform;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Transform = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(new Vector3(0, 0, -10), ForceMode.Force);
            Debug.Log("Q");
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, -10), ForceMode.Acceleration);
            Debug.Log("W");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.AddForce(new Vector3(0, 0, -10), ForceMode.Impulse);
            Debug.Log("E");
        }


        if (Input.GetKey(KeyCode.R))
        {
            rb.AddForce(new Vector3(0, 0, -0.1f), ForceMode.VelocityChange);
            Debug.Log("velocity" + rb.velocity);
            Debug.Log("R");
        }

    }
}
