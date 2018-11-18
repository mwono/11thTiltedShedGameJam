using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasp : Enemies {
    public GameObject player;
    public int moveSpeed;

    Collider2D coll;
    float timer;
    internal override void enemyBehavior()
    {
        this.transform.position += this.transform.forward * moveSpeed * Time.deltaTime;
    }

    // Use this for initialization
    void Start () {
        coll = this.GetComponent<Collider2D>();
        coll.enabled = false;
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.LookAt(player.transform);
        timer += Time.deltaTime;
        if (timer >= 40)
        {
            coll.enabled = true;
            enemyBehavior();
        }
	}
}
