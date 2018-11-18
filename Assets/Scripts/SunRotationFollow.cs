using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotationFollow : MonoBehaviour {
    public float followDistance;

    Vector3 main;
	// Use this for initialization
	void Start () {
        main = Camera.main.transform.position;
        this.gameObject.transform.position = main;
	}
	
	// Update is called once per frame
	void Update () {
		if (main.sqrMagnitude - this.gameObject.transform.position.sqrMagnitude >= followDistance)
        {
            Vector3.Lerp(this.gameObject.transform.position, main, .1f);
        }
	}
}
