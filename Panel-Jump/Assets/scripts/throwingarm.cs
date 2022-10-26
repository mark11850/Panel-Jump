using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwingarm : MonoBehaviour
{
    public GameObject throwingrock;
    float rockspeed = 100f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            Instantiate(throwingrock, transform.position, transform.rotation);

        transform.forward = throwingrock.transform.position * rockspeed * Time.deltaTime;

        Destroy(throwingrock, 2f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("ouch");
    }
}
