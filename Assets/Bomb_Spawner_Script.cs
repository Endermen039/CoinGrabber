using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Spawner_Script : MonoBehaviour
{

    public GameObject bomb; 

    public Coin_Spawner_Script coinSpawnScript;
    public Logic_Script Logic;

    public Sprite newSprite;

    public float width = 7f;
    public float height = 8f;



    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBomb()
    {
        float randomX = Random.Range(-width / 2, width / 2);
        float randomY = Random.Range(-height / 2, height / 2);
        Vector2 spawnPosition = new Vector2(randomX + 0.5f, randomY);

        Instantiate(bomb, spawnPosition, Quaternion.identity);

    }

    private void FixedUpdate()
    {


    }
}
