using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaunchObject : MonoBehaviour
{
    public float launchForce = 10.0f;
    public Rigidbody rb;
    public float speed = 0.001f;


    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
            rb.AddForce(gameObject.transform.forward * launchForce);
        }
        {
            gameObject.transform.Translate(gameObject.transform.forward * speed);
        }
        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.name == "Cube(6)")
            {
                col.gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }

    }
}