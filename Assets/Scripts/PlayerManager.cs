using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerManager : MonoBehaviour
{
    public float speedX;
	public float jumpSpeedY;
	public float delayBeforeDoubleJump;
	public GameObject Interact1, Interact2, Interact3, Interact4, Interact5;
	bool facingRight,Jumping, isGrounded, canDoubleJump;
	float speed;
    Animator anim;
	Rigidbody2D rb;
	
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
		rb = GetComponent<Rigidbody2D> ();
		facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(speed);
		//left
		if(Input.GetKeyDown(KeyCode.LeftArrow)) {
			speed = -speedX;
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			speed = 0;
		}
		//right
		if(Input.GetKeyDown(KeyCode.RightArrow)) {
			speed = speedX;
		}
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			speed = 0;
		}
		//jump
		if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded) {
			Jump();
			// audioSource.PlayOneShot(JumpSound);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow) && canDoubleJump) {
			Jump();
			// audioSource.PlayOneShot(JumpSound);
		}
		Flip();
    }
    //Buat Player bergerak
	void MovePlayer(float playerSpeed) {

		if(playerSpeed < 0  && !Jumping || playerSpeed > 0 && !Jumping) {
			anim.SetInteger("State", 1);
		}
		if(playerSpeed == 0 && !Jumping)
        {
            anim.SetInteger("State", 0);
        }

        rb.velocity = new Vector3 (speed, rb.velocity.y, 0);
	}
    void Flip() {
		if(speed > 0 && !facingRight || speed < 0 && facingRight)
		{
			facingRight = !facingRight;

			Vector3 temp = transform.localScale;
			temp.x *= -1;	
			transform.localScale = temp;
		}
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "GROUND") 
        {
			canDoubleJump = false;
			isGrounded = true;
            Jumping = false;
			anim.SetInteger ("State", 0);
			
        }
			
    }
	void OnTriggerEnter2D(Collider2D coll) 
	{
		if(coll.gameObject.tag == "Interaction") 
        {
			Interact1.SetActive(true);
        }
		if(coll.gameObject.tag == "Interaction2") 
        {
			Interact2.SetActive(true);
        }	
		if(coll.gameObject.tag == "Interaction3") 
        {
			Interact3.SetActive(true);
        }	
		if(coll.gameObject.tag == "Interaction4") 
        {
			Interact4.SetActive(true);
        }	
		if(coll.gameObject.tag == "Interaction5") 
        {
			Interact5.SetActive(true);
        }		
	}
	void OnTriggerExit2D(Collider2D coll) 
	{
		if(coll.gameObject.tag == "Interaction") 
        {
			Interact1.SetActive(false);
        }	
		if(coll.gameObject.tag == "Interaction2") 
        {
			Interact2.SetActive(false);
        }
		if(coll.gameObject.tag == "Interaction3") 
        {
			Interact3.SetActive(false);
        }
		if(coll.gameObject.tag == "Interaction4") 
        {
			Interact4.SetActive(false);
        }
		if(coll.gameObject.tag == "Interaction5") 
        {
			Interact5.SetActive(false);
        }
	}
    public void WalkLeft() {
		speed = -speedX;
	}

	public void WalkRight() {
		speed = speedX;
	}
	public void StopMoving() {
		speed = 0;
	}
	public void Jump() {
		//single jump
		if (isGrounded)	{
			Jumping = true;
			isGrounded = false;
			rb.AddForce (new Vector2 (rb.velocity.x, jumpSpeedY));
			anim.SetInteger ("State", 2);
			Invoke("EnableDoubleJump", delayBeforeDoubleJump);
			// audioSource.PlayOneShot(JumpSound);
		}

		//double jump
		if (canDoubleJump) {
			canDoubleJump = false;
			rb.AddForce (new Vector2 (rb.velocity.x, jumpSpeedY));
			anim.SetInteger ("State", 2);
			// audioSource.PlayOneShot(JumpSound);
		}
	}
    void EnableDoubleJump() {
		canDoubleJump = true;
	}
}
