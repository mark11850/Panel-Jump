using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakecube : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        rb.useGravity = true;
    }


}
