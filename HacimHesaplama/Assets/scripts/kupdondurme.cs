using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kupdondurme : MonoBehaviour
{
    Rigidbody rb;
    public float hiz;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Time.deltaTime*60, 0, 0);
    }
    private void Update()
    {
        if (transform.position.x <= -2.98f)
        {
            rb.velocity = new Vector3(Time.deltaTime*hiz, 0, 0);
            transform.Rotate(30, 30, 1);
        }
        if (transform.position.x >= 3.0f)
        {
            transform.Rotate(-30, -30, -30);
            rb.velocity = new Vector3(-Time.deltaTime*hiz, 0, 0);
        }
    }
}
