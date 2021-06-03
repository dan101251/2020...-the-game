using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)          // on floor, allows player to jump
    {
        if (collision.collider.tag == "Floor")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = true;        // sets isGrounded to true
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)           // not on floor, doesnt allow player to jump
    {
        if (collision.collider.tag == "Floor")
        {
            Player.GetComponent<PlayerMovement>().isGrounded = false;       // sets isGrounded to true
        }
    }
}
 