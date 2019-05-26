using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Text HighScore;
    void Start()
    {
        gameObject.active = false;
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void menuV()
    {
        gameObject.active = true;
        
    }
    public void play()
    {
        Score.scoreValue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void resetScore()
    {
        Score.scoreValue = 0;
        PlayerPrefs.DeleteKey("HighScore");
        HighScore.text = "0";
    }
    public void Quit()
    {
        Application.Quit();
    }
}
