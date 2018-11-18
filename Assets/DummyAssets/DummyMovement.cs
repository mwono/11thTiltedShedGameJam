using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyMovement : MonoBehaviour {
    public int speed = 10;

    Rigidbody2D rb;
    Collider2D coll;

	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        coll = this.gameObject.GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity =  new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}
}
