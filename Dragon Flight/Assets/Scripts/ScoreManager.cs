using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text coinText;
    public int coinCount = 0;

    public void addCoin()
    {
        coinCount = coinCount + 1;
        coinText.text = " X " + coinCount;
    }
}
