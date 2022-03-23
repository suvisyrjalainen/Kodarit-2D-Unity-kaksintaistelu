using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	private float horizontalMovement = 0f;
	public float speed = 5f;
	public float JumpForce = 7.5f;
	
	public Rigidbody2D MyRigidbody2D;
	
	public CircleCollider2D Feet;
	
	public Animator MyAnimator;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
		MyRigidbody2D.velocity = new Vector2(horizontalMovement * speed, MyRigidbody2D.velocity.y);
		
		MyAnimator.SetFloat("walk", Mathf.Abs(horizontalMovement));
		
		if(Input.GetButtonDown("Jump")  && Feet.IsTouchingLayers(LayerMask.GetMask("Ground"))){
			MyRigidbody2D.AddForce(new Vector2(0f,JumpForce), ForceMode2D.Impulse);
			MyAnimator.SetTrigger("jump");
		}
		
		if(Feet.IsTouchingLayers(LayerMask.GetMask("Ground"))){
			MyAnimator.SetBool("isGrounded", true);
		}
		else{
			MyAnimator.SetBool("isGrounded", false);
		}
    }
	
	
}
