using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    //private Rigidbody  Rb;
    private float horizontalInput;
	
    // Start is called before the first frame update
    void Start()
    {
        //Rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime * horizontalInput);
        //(transform.rotation.y < 45)
        //if(Input.GetKeyDown(KeyCode.RightArrow) ){
           //transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
		 //Rb.AddTorque(0f,1f,0f, ForceMode.Impulse);

        
		//}
        //Debug.Log(horizontalInput);
    }
    
}
