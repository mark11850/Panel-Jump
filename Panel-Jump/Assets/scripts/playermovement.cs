using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float FallMultiplier = 50f;
    public Rigidbody rb;
    public float jumpforce = 5f;
    public bool grounded = false;
   // public GameObject throwingrock;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * 2 * Time.deltaTime;
        
        if(Input.GetKey(KeyCode.S))
            transform.position -= transform.forward * 2 * Time.deltaTime;
       
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * 2 * Time.deltaTime;
        
        if( Input.GetKey(KeyCode.A))
            transform.position -= transform.right * 2 * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(0, -0.5f, 0);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(0, 0.5f, 0);
        
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

        //if (Input.GetKeyDown(KeyCode.F))
          //  Instantiate(throwingrock, transform.position, transform.rotation);

        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (FallMultiplier - 1) * Time.captureDeltaTime;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}

