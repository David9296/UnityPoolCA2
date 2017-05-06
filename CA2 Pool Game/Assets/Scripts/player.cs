using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    Text p1Score;
    Text p2Score;

    public int score1;
    public int score2;

    // Use this for initialization
    void Start () {

        p1Score = GameObject.FindGameObjectWithTag("p1Score").GetComponent<Text>();
        p2Score = GameObject.FindGameObjectWithTag("p2Score").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
      
        
    }


    public void updateScore1()
    {
        p1Score.text = score1.ToString();
    }

    public void updateScore2()
    {
        p2Score.text = score2.ToString();
    }

   public void OnClick()
    {
        SceneManager.LoadScene("game");
    }

}
