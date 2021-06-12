using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject prevGround;
    public GameObject ground;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > ground.transform.position.x)
        {
            var tempGround = prevGround;
            prevGround = ground;
            tempGround.transform.position += new Vector3(39, 0, 0);
            ground = tempGround;
        }

        bool coinSpawned = false;
        while (!coinSpawned)
        {
            Vector3 coinPosition = new Vector3(Random.Range(20f, 30f), Random.Range(-2f, 5.5f), 0f);
            if ((coinPosition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                nextCoin = Instantiate(coin, coinPosition, Quaternion.identity);
                nextCoin.name = "Coin";
                coinSpawned = true;
            }
        }
    }
}
