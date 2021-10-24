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
    // Start is called before the first frame update
    void Start()
    {
        batSpawnTimer = Random.Range(5.5f, 10.5f);
        wolfSpawnTimer = Random.Range(4.5f, 9.5f);
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

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(batCooldown());
        StartCoroutine(wolfCooldown());
    }
}
