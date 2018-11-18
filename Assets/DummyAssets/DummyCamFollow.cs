using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCamFollow : MonoBehaviour {
    public GameObject player;
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -20);
=======
        this.transform.position = new Vector3(player.transform.position.x, 4, -7);
>>>>>>> origin/LevelDesign
    }
}
