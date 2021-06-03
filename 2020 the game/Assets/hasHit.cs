using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hasHit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I trigger hit: " + collision.gameObject.name);   // checking if corona hits player
        SceneManager.LoadScene("GameOver");
    }

    // checks if corona has hit player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I collided with: " + collision.gameObject.name); // checking if corona hits player
        SceneManager.LoadScene("GameOver");
    }
}
