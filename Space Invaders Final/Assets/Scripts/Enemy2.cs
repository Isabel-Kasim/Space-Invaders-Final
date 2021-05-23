using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int hiscore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Animator>().SetTrigger("Death");
        Destroy(collision.gameObject); // destroy bullet
        Debug.Log("Ouch!");
        if (collision.gameObject.tag == "Bullet")
        {
            score = score + 50;
            Debug.Log("score = " + score);
            hiscore += score;
            scoreText.text = score.ToString();
            hiscoreText.text = hiscore.ToString();
        }

    }
}