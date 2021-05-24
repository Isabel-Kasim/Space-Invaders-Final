using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public int score = 0;
    public int hiscore = 0;
    

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        hiscoreText = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("0000");
        hiscoreText.text = hiscore.ToString("0000");
    }
    /*
    void ScoreKeeper()
    {
        if (enemy0.score_hit == true)
        {
            score = score + 10;
            Debug.Log("score = " + score);
            hiscore += score;
            scoreText.text = score.ToString();
            hiscoreText.text = hiscore.ToString();
            enemy0.score_hit = false;
            Debug.Log("Enemy bool = " + enemy0.score_hit);
        }
    }
    */
}
