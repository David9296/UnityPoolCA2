using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public bool isStripped;
    public bool isBlack;
    public player play;
    private Vector3 initialPosition;
    public Canvas gameOver;

	// Use this for initialization
	void Start ()
    {
        initialPosition = transform.position;
        gameOver = GameObject.FindGameObjectWithTag("WinCanvas").GetComponent<Canvas>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "pocket" & isStripped)
        {
            play.score1++;
            play.updateScore1();
            Destroy(gameObject);
           
        }

        else if (other.tag == "pocket" & !isStripped)
        {
            play.score2++;
            play.updateScore2();
            Destroy(gameObject);
        }

        else if(other.name == "Floor")
        {
            gameObject.transform.position = initialPosition;
        }


        if (other.tag == "pocket" && isBlack)
        {
            if (play.score1 >= 7 || play.score2 >= 7)
            {
                
                gameOver.enabled = true;
            }

            else if(play.score1 < 7 || play.score2 < 7)
            {
                
                gameOver.enabled = true;
            }

        }

    }
}
