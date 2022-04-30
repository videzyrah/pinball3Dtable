using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldGameBall : MonoBehaviour
{
    private Rigidbody rb;
    public float maxAngularVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().maxAngularVelocity = 100f;
        
		rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
		 rb.useGravity = true;
		}
    }
}
