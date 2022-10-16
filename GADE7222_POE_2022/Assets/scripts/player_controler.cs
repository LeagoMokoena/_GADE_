using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class player_controler : MonoBehaviour
{
    /*
    public float turnsp;
    public float GRAV; 

    private Rigidbody rb;*/
    public float sp = 1f;
    // Start is called before the first frame update

    void Update()
    {
        float xdir = Input.GetAxis("Horizontal");
        float zdir = Input.GetAxis("Vertical");

        Vector3 movedir = new Vector3(xdir, 0.0f, zdir);

        transform.position += movedir * sp;
    }
    // Update is called once per frame
    /*void FixedUpdate()
    {
        forwardMove();
        sideMove();
        downMove();
    }

    void forwardMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * sp * 10);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(new Vector3(Vector3.forward.x, 0, Vector3.forward.z) * -sp * 10);
        }
    }

    void sideMove()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(Vector3.up * turnsp * 10);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(-Vector3.up * turnsp * 10);
        }
    }

    void downMove()
    {
        rb.AddForce(Vector3.down * GRAV * 10);
    }*/
}
