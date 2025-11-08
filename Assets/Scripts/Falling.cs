using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Falling : MonoBehaviour
{
    public AudioSource fallingSound;
    


    void Start()
    {
        
        fallingSound = GetComponent<AudioSource>();
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "Player")
        {
            StartCoroutine(WaitForSecs());
        }
    }
    IEnumerator WaitForSecs()
    {
        fallingSound.Play();
        yield return new WaitForSeconds(2);
        Restart();
        ScoreManager.instance.Deaths();
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
