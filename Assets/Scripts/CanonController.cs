using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
	public GameObject projectilePrefab;
	public int canonAmmoCount = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space) && canonAmmoCount > 0)
		{
			//Launch a projectile from canon
			Instantiate(projectilePrefab, new Vector3(transform.position.x, 0.05f ,transform.position.z), projectilePrefab.transform.rotation);
		}  
    }
}
