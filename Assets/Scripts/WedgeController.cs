using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WedgeController : MonoBehaviour
{
    public int framecount = 0;
	public int stopCount = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (framecount < stopCount){
          transform.Translate(0, 0, -Time.deltaTime);
		  framecount++;
		} 
        if (framecount >= stopCount && framecount < stopCount * 2){
          transform.Translate(0, 0, Time.deltaTime);
		  framecount++;
		} 
        if(framecount >= stopCount * 2){
         framecount = 0;
        }
    }
}
