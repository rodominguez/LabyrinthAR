using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravity : MonoBehaviour
{

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, 0.24f, transform.localPosition.z);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
