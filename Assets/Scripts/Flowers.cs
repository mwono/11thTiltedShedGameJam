using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour {
    public GameObject UI;
    public int score;

    Collider2D coll;

	// Use this for initialization
	void Start () {
        coll = this.gameObject.GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UI.GetComponent<UIManager>().updateScore(score);
            this.gameObject.SetActive(false);
        }
    }
}
