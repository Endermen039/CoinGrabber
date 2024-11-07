using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_Collision_Script : MonoBehaviour
{

    public Coin_Spawner_Script coinSpawner;
    public Logic_Script logic;
    public Portal_Script portal;
    public Heart_System_Script heartSystem;
    public AudioSource src;
    public AudioClip sfx1, sfx2, sfx3;

    private void OnCollisionEnter2D(Collision2D collider)
    {
        // Check if the player collides with a coin
        if (collider.gameObject.CompareTag("Coin"))
        {
            src.clip = sfx1;
            src.Play();

            portal.speed += 0.1f;

            logic.addScore();
            // Destroy the coin
            Destroy(collider.gameObject);

            // Call the CoinSpawner to spawn a new coin at a random location

            coinSpawner.SpawnCoin();
        }

        if (collider.gameObject.CompareTag("Bomb"))
        {
            src.clip = sfx2;
            src.Play();

            Destroy(collider.gameObject);
            if(heartSystem.shields == 0)
            {
                src.clip = sfx3;
                src.Play();

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            heartSystem.TakeDamage();


        }
    }
}
