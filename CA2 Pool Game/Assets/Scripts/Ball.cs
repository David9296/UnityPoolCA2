using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour {

    public Transform CueObj;
    public bool cue;
    public Transform spawn;
    public Transform camerareset;
    public Camera mainCam;

    public bool player1 = true;

    Text p1;
    Text p2;

    // Use this for initialization
    void Start ()
    {
        p1 = GameObject.FindGameObjectWithTag("p1").GetComponent<Text>();
        p2 = GameObject.FindGameObjectWithTag("p2").GetComponent<Text>();
    }

    void Update()
    {

        
        if (Input.GetKeyDown("space") && cue ==false)
        {
           
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            Instantiate(CueObj, transform.position, CueObj.rotation);
            cue = true;

            if (player1 == true)
            {
                p1.text = " ";
                p2.text = "^";
                player1 = false;
            }

            else if (!player1)
            {
                p2.text = " ";
                p1.text = "^";
                player1 = true;
            }

        }

     
    }
	
	// Update is called once per frame
	
  void OnTriggerEnter(Collider other)
    {
        if (other.name == "Floor")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            transform.position = spawn.position;
            mainCam.transform.position = camerareset.position;
                
        }

       

    }

    void OnCollisionEnter(Collision other)
    {
        cue = false;

    }




    }
