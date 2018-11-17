using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private Rigidbody2D m_Rigidbody2D;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;
    
    Transform playerPosition;
    bool m_FacingRight = true;
    private Vector3 m_Velocity = Vector3.zero;

    public float thrustSpeed = 16f;

    // Use this for initialization
    void Awake () {
        playerPosition = GetComponent<Transform>();
        m_Rigidbody2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Move(float move, bool thrust)
    {
        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
        // And then smoothing it out and applying it to the character
        m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

        // If the input is moving the player right and the player is facing left...
        if (move > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (move < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }

        if (thrust)
        {
            m_Rigidbody2D.AddForce(new Vector2(0f, thrustSpeed));
        }
    }

    public void Flip()
    {
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
