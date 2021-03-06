using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WedgeController : MonoBehaviour
{
    public int framecount = 0;
	public int stopCount = 100;
    private Rigidbody  Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (framecount < stopCount){
          
          //(can use with "is  kinematic")
          transform.Translate(0, 0, -Time.deltaTime);
          //Rb.AddForce(-Vector3.forward * 5.0f, ForceMode.Impulse);
          //Rb.velocity = new Vector3(0,0,-1);
          //Debug.Log("Move down please");
		  framecount++;
		} 
        if (framecount >= stopCount && framecount < stopCount * 2){
          transform.Translate(0, 0, Time.deltaTime); 
          //Rb.velocity = new Vector3(0,0,1);
          //Debug.Log("Move up please");
		  framecount++;
		} 
        if(framecount >= stopCount * 2){
         framecount = 0;
        }
    }
}
