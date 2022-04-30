using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slap : MonoBehaviour
{
    public float flipperForce;
    // Start is called before the first frame update
    void Start()
    {
        
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
			Vector3 _awayFromFlipper = (collision.gameObject.transform.position - transform.position);
            Debug.Log("Vector3 for flipper collision = " + _awayFromFlipper);
            _awayFromFlipper.y = -0.4f;
			//apply force upon ball 
			_ballRigidbody.AddForce(_awayFromFlipper * flipperForce, ForceMode.Impulse); 
	}
}
