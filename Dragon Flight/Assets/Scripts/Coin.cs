using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ScoreManager SM;
    public GameObject coin;
    public AudioClip coinSound;
    public GameObject nextCoin;

    // Update is called once per frame
    void Start()
    {
        SM = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
        // nextCoin = nextCoin;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SM.addCoin();
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(coin.gameObject);
        // spawnCoin();
    }

    // private void spawnCoin()
    // {
    //     bool coinSpawned = false;
    //     while (!coinSpawned)
    //     {
    //         Vector3 coinPosition = new Vector3(Random.Range(20f, 30f), Random.Range(-2f, 5.5f), 0f);
    //         if ((coinPosition - transform.position).magnitude < 3)
    //         {
    //             continue;
    //         }
    //         else
    //         {
    //             nextCoin = Instantiate(coin, coinPosition, Quaternion.identity);
    //             nextCoin.name = "Coin";
    //             coinSpawned = true;
    //         }
    //     }
    // }
}
