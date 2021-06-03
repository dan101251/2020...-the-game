using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class PlayerMovement : MonoBehaviour
{
    // variables for each collider on player
    public BoxCollider2D running;
    public BoxCollider2D slide;
    public BoxCollider2D jump;

    // controls what animation plays
    Animator AnimatorController; 

    // sets grounded to false
    public bool isGrounded = false;
    // Update is called once per frame
    private void Start()
    {
        // changes the animation of called animator
        AnimatorController = gameObject.GetComponent<Animator>();

        // grab component for boxcolliders
        running = running.GetComponent<BoxCollider2D>();
        slide = slide.GetComponent<BoxCollider2D>();
        jump = jump.GetComponent<BoxCollider2D>();
        // deactivate slide and jump colliders 
        slide.enabled = false;
        jump.enabled = false;
    }

    void Update()
    {
        Jump();
        slide.enabled = false;
        jump.enabled = false; 
    }

    void Jump()
    { 
        //allows player to jump if character is grounded
        if (Input.GetButtonDown("Jump") && isGrounded == true)  // "Jump" is set to SPACE bar and w key
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5.5f), ForceMode2D.Impulse);
            AnimatorController.SetTrigger("Jump");
            // turn off running boxcollider and turn on jump NOTE: sleep.thread can be used to change back to running
            jump.enabled = true;
            running.enabled = false;
        }
        else
        {
            jump.enabled = false;
            running.enabled = true;
        }

        // allow player to slide if grounded
        if (Input.GetButtonDown("Slide") && isGrounded == true) // "Slide" is set to c key
        {
            AnimatorController.SetTrigger("Slide");
            slide.enabled = true;
            running.enabled = false;
        }
    }
}
