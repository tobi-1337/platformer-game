using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance = null;
    public static ScoreManager Instance
    
        {
            get { return instance; }
        }
    
    public Text scoreText;
    public Text togoText;
    public Text deathsText;

    int score = 0;
    int togo = 30;
    int deaths = 0;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " APPLES";
        togoText.text = togo.ToString() + " TO GO";
        deathsText.text = "DEATHS:" + deaths.ToString();
        DontDestroyOnLoad(gameObject);
        
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " APPLES";
        togo -= 1;
        togoText.text = togo.ToString() + " TO GO";
        

    }

    public void Deaths()
    {
        deaths += 1;
        deathsText.text = "DEATHS: " + deaths.ToString();
        PlayerPrefs.SetInt("deaths", deaths);
    }
    
}
