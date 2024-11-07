using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner_Script : MonoBehaviour
{

    public GameObject coin;

    public float height = 9f;
    public float width = 9f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCoin()
    {
        float randomX = Random.Range(-width / 2, width / 2);
        float randomY = Random.Range(-height / 2, height / 2);
        Vector2 spawnPosition = new Vector2(randomX, randomY);

        Instantiate(coin, spawnPosition, Quaternion.identity);
    }

}
