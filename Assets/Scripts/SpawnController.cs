using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Wolf;
    public GameObject Bat;
    public GameObject Coin;

    public GameObject WolfSpawn;
    public GameObject BatSpawn;
    public GameObject CoinSpawn;

    float wolfSpawnTimer;
    float batSpawnTimer;
    float coinSpawnTimer;

    int batCount;
    int wolfCount;
    int coinCount;

    bool canSpawnBat = true;
    bool canSpawnWolf = true;
    bool canSpawnCoin = true;
    // Start is called before the first frame update
    void Start()
    {
        batSpawnTimer = Random.Range(5.5f, 10.5f);
        wolfSpawnTimer = Random.Range(4.5f, 9.5f);
        coinSpawnTimer = Random.Range(20.5f, 25.5f);
    }

    IEnumerator batCooldown()
    {
        if (canSpawnBat)
        {
            Instantiate(Bat, BatSpawn.transform);
            canSpawnBat = false;
            yield return new WaitForSeconds(batSpawnTimer);
            canSpawnBat = true;

            batSpawnTimer = Random.Range(5.5f, 10.5f);
        }
    }

    IEnumerator wolfCooldown()
    {
        if (canSpawnWolf)
        {
            Instantiate(Wolf, WolfSpawn.transform);
            canSpawnWolf = false;
            yield return new WaitForSeconds(wolfSpawnTimer);
            canSpawnWolf = true;

            wolfSpawnTimer = Random.Range(4.5f, 9.5f);
        }
    }

    IEnumerator coinCooldown()
    {
        if (canSpawnCoin)
        {
            Instantiate(Coin, CoinSpawn.transform);
            canSpawnCoin = false;
            yield return new WaitForSeconds(coinSpawnTimer);
            canSpawnCoin = true;

            coinSpawnTimer = Random.Range(20.5f, 25.5f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        StartCoroutine(batCooldown());
        StartCoroutine(wolfCooldown());
        StartCoroutine(coinCooldown());
    }
}
