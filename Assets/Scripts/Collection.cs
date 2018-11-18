using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour {
    public GameObject UI;

    Collider2D coll;

	// Use this for initialization
	void Start () {
        coll = this.gameObject.GetComponent <Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Show Win Screen on UI here
            collision.GetComponent<DummyMovement>().enabled = false;
            collision.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            UI.GetComponent<UIManager>().timeLimit = float.MaxValue;
        }
    }
}
