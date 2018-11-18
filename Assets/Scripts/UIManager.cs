using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public float timeLimit;
    public GameObject player;
    public GameObject cam;
    public Text scoreText;
    public GameObject pauseMenu;

    int score;

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
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            cam.GetComponent<CameraController>().enabled = false;
            showPause();
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

    public void showPause()
    {
        pauseMenu.SetActive(true);
    }
}
