using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rockscript : MonoBehaviour
{

    float rockspeed = 100f;
    public Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = body.transform.position * rockspeed * Time.deltaTime;
       
        Destroy(body, 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
    }

}
