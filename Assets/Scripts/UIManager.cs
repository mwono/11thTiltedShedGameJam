using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public float timeLimit;
    public GameObject player;
    public GameObject cam;

    int score;
    Text scoreText;

    float timer;
    float startTime;//Note: Might not need start time?

    // Use this for initialization
    void Start () {
        scoreText = this.gameObject.GetComponentInChildren<Text>();
        startTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        if ((timer - startTime) >= timeLimit)
        {
            Debug.Log("FREEZE");
            player.GetComponent<DummyMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            cam.GetComponent<DummyCamFollow>().enabled = false;
            //SHOW END GAME MENU HERE
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void updateScore(int sc)
    {
        score += sc;
        scoreText.text = score.ToString();
    }
}
