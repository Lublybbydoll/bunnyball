using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // This is a varible for the shockwave Prefab
    [SerializeField] GameObject shockwavePrefab;
    // This is a variable for the game manager
    [SerializeField] GameManager gameManager;

    // This fuction runs once at the beginning of the game
    private void Start()
    {
        // Finds the game manager
        gameManager = FindObjectOfType<GameManager>();
    }
    // This fuction runs when you collide with the trigger
    private void OnTriggerEnter(Collider other)
    {
	// checks if we collide with something tagged as "Player"
        if (other.CompareTag("Player")) {
            // If we do collide with something tagged as Player 

            // Gameover is true 
            gameManager.gameOver = true;
            // Creates a shockwave
            Instantiate(shockwavePrefab, transform.position, Quaternion.identity);
            // Destroys this gameobject
            Destroy(gameObject, 0.1f);
        }
    }
}
