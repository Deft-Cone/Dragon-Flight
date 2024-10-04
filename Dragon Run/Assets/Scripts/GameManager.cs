using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject prevGround;
    public GameObject ground;
    public GameObject player;

    private ScoreManager theScoreManager;

    // Start is called before the first frame update
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
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
    }

    // public void RestartGame()
    // {
    //     StartCoroutine("RestartGameCo");
    // }

    // public IEnumerator RestartGameCo()
    // {
    //     theScoreManager.scoreIncreasing = false;

    //     theScoreManager.scoreCount = 0;
    //     theScoreManager.scoreIncreasing = true;
    // }
}
