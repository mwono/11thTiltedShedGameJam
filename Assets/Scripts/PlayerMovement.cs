using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController controller;
    float xMove = 0;
    float flySpeed = 20f;
    bool isFlying = false;
	
	// Update is called once per frame
	void Update () {

        xMove = (Input.GetAxisRaw("Horizontal")) * flySpeed;

        isFlying = Input.GetKey(KeyCode.W);

	}

    private void FixedUpdate()
    {
        controller.Move(xMove * Time.fixedDeltaTime, isFlying);
    }
}
