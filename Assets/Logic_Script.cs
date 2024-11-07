using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic_Script : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Bomb_Spawner_Script bombSpawner;

    public void addScore()
    {
        playerScore += 1;
        scoreText.text = "Score: " + playerScore.ToString();
        bombSpawner.SpawnBomb();
    }


}
