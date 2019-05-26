using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    public Text HighScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
        score = GetComponent<Text>();
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + scoreValue;
        if (scoreValue>PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
            HighScore.text = scoreValue.ToString();
        }
    }
}
