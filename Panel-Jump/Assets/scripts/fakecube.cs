using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakecube : MonoBehaviour
{   //this ended up being a pointless script and I could get the false floors working without it

    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject player;

    private void Update()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "player")
        rb.useGravity = true;

        print("colision detected");

    }

}
