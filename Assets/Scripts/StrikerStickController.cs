using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikerStickController : MonoBehaviour
{
	private Rigidbody  Rb;
	public float strikerForce = 5f;
	
	public float speed = 5.0f;
	public int framecount = 0;
	public int stopCount = 100;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
		Rb.AddForce(Vector3.forward * strikerForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
		//if (framecount > stopCount){
          //transform.Translate(-Vector3.forward * Time.deltaTime * speed);
		  //framecount++;
		//} 
		if (transform.position.z > -6) {
			Destroy(gameObject);
		}
		
    }
	private void OnCollisionEnter(Collision collision)
	{ 
			Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
			//get direction to send enemy in
			Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);
			//apply force upon enemy 
			ballRigidbody.AddForce(awayFromPlayer * 50f, ForceMode.Impulse);
	}
}
