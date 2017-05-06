using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolCue : MonoBehaviour {

    public Ball whiteBall;

	// Use this for initialization
	void Start () {

       
        GetComponent<ConstantForce>().enabled = false;


	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<ConstantForce>().enabled = true;
            Debug.Log("Working");
        }

	}

    void OnCollisionEnter(Collision other)
    {
        

        if (other.collider.tag == "WhiteBall")
        {
           
            Destroy(gameObject);
            
        }
        else
        {
            //
        }
    }

  
    

}
