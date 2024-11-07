using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx1;

    public void restartGame()
    {

        src.clip = sfx1;
        src.Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
