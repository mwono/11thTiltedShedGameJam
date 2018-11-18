using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour {
    public GameObject UI;

    AudioSource vict;

	// Use this for initialization
	void Start () {
        vict = this.gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            UI.GetComponent<UIManager>().showPause();
            collision.GetComponent<PlayerMovement>().enabled = false;
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            collision.GetComponent<Rigidbody2D>().gravityScale = 0.0f;
            UI.GetComponent<UIManager>().timeLimit = float.MaxValue;
            vict.Play();
        }
    }
}
