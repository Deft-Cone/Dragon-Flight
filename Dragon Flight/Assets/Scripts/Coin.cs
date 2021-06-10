using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public ScoreManager SM;
    public AudioClip coinSound;

    // Update is called once per frame
    void Start()
    {
        SM = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SM.addCoin();
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
    }
}
