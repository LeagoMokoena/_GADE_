using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using System;

public class camra : MonoBehaviour
{
    public float eed;
    public Transform tar;
    public Vector3 dias;
    public Transform looks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 hpos = tar.position + dias;
        Vector3 vpos = Vector3.Lerp(transform.position, hpos, eed * Time.deltaTime);
        transform.position = vpos;
        transform.LookAt(looks.position);
    }
}
