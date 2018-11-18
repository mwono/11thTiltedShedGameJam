using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butterfly : Enemies {
    internal override void enemyBehavior()
    {
        if (movingRight)
        {
            this.transform.position += new Vector3(1, this.transform.position.y) * Time.deltaTime;
        } else
        {
            this.transform.position -= new Vector3(1, this.transform.position.y) * Time.deltaTime;
        }
        if (this.transform.position.x - origPos.x >= 1)
        {
            movingRight = false;
        } else if (this.transform.position.x - origPos.x <= -1)
        {
            movingRight = true;
        }
    }

    Vector3 origPos;
    bool movingRight = true;
    // Use this for initialization
    void Start () {
        origPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        enemyBehavior();
	}
}
