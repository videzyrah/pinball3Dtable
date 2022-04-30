using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperRingController : MonoBehaviour
{
    private Rigidbody  Rb;
	public float bumperForce;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
	{ 
			Rigidbody _ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();
			//get direction to send ball in
            //Vector3 _noYvector = new Vector3(1,0,1);
			Vector3 _awayFromBumper = (collision.gameObject.transform.position - transform.position);
            Debug.Log("Vector3 for collision = " + _awayFromBumper);
            _awayFromBumper.y = -0.4f;
			
			//apply force upon ball 
			_ballRigidbody.AddForce(_awayFromBumper * bumperForce, ForceMode.Impulse); 
	}
}
