using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public Transform coinPoint;
    public float coinSpawnPoint;

    public float distanceBetween;

    private float platformWidth;

    public ObjectPooler theObjectPool;

    private CoinGenerator theCoinGenerator;
    public float randomCoinThreshold;
    private Vector3 randomPos;
    public Vector3 center;
    public Vector3 size;
    

    // Start is called before the first frame update
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        theCoinGenerator = FindObjectOfType<CoinGenerator>();
        coinSpawnPoint = coinPoint.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            // Instantiate(thePlatform, transform.position, transform.rotation);

            GameObject newPlatform = theObjectPool.GetPooledObject(); // Create a new gameobject by pulling from the ojbect inside the pooled object list

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            if (Random.Range(0f, 100f) < randomCoinThreshold)
            {
               randomPos = new Vector3(transform.position.x, Random.Range(-size.y / 2, size.y / 2), 0);
               theCoinGenerator.SpawnCoins(randomPos); 
            }
            
        }
    }
}