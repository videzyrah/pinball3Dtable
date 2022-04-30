using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikerStickController : MonoBehaviour
{
	private Rigidbody  Rb;
	public float strikerForceMax = 20f;
	
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		//if (framecount > stopCount){
          //transform.Translate(-Vector3.forward * Time.deltaTime * speed);
		  //framecount++;
		//} 
		if(Input.GetKeyDown(KeyCode.Space)){
		 Rb.AddForce(Vector3.forward * 5f, ForceMode.Impulse);
		}
		if (transform.position.z > -5) {
			Rb.velocity = new Vector3(0,0,0);
		}
		
    }
	private void OnCollisionEnter(Collision collision)
	{ 
			Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
			//get direction to send ball in
			//Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
			Vector3 awayFromStriker = new Vector3(0,0,1);
			//apply force upon ball 
			ballRigidbody.AddForce(awayFromStriker * strikerForceMax, ForceMode.VelocityChange); 
	}
}
