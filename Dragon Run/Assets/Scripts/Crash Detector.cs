using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem coinEffect;
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Debug.Log("Hit your head.");
            coinEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
        if (collision.tag == "Obstacle")
        {
            Debug.Log("Hit your head.");
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
