using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour {
    public int score = 0;
    private float movement=0f;
    public float jump = 7f;
        public float speed=5f;
    public Transform groundCheckpoint;
    public float groundradius;
    public LayerMask  groundlayermask;
    public bool isgroundTouch;
    private Rigidbody2D rigidBody;
	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        isgroundTouch = Physics2D.OverlapCircle(groundCheckpoint.position, groundradius, groundlayermask);
        movement = Input.GetAxis("Horizontal");
        if (movement != 0f)
        {
            rigidBody.velocity = new Vector2 (movement *speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, rigidBody.velocity.y);
        }
       
        if (Input.GetButtonDown("Jump")  && isgroundTouch  )
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump);
        }
		
	}
}
