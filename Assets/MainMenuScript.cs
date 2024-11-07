using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public AudioSource src;
    public AudioClip sfx1, sfx2;

    public void playGame()
    {
        src.clip = sfx1;
        src.Play();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        src.clip = sfx2;
        src.Play();

        Application.Quit();
    }
}
