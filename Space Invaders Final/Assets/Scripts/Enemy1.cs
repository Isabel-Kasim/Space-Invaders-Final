using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Enemy1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public int hiscore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public float speed = 0.03f;
    public Transform enemyT;
    public AudioSource enemyBoom;
    public AudioSource playerDeath;
    //public Score score;

    void Start()
    {
        enemyT = GetComponent<Transform>();
        InvokeRepeating("Enemymovement", 0.1f, 0.3f);
        //score = GetComponent<Score>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        enemyBoom.Play();
        GetComponent<Animator>().SetTrigger("Death");
        Destroy(collision.gameObject); // destroy bullet
        if (collision.gameObject.tag == "Player")
        {
            GameOver.isPlayerDead = true;
            //playerDeath.Play();
            Time.timeScale = 0;
            SceneManager.LoadScene("Credits");
        }
        Debug.Log("Ouch!");
        if (collision.gameObject.tag == "Bullet")
        {
            score += 10;
            Debug.Log("score = " + score);
            hiscore += score;
            scoreText.text = score.ToString();
            hiscoreText.text = hiscore.ToString();
        }

    }

    void Enemymovement()
    {
        enemyT.position += Vector3.down * speed;
        /*
        foreach (Transform enemy in enemyT)
        {
            if (enemy.position.x < -10.5 || enemy.position.x > 10.5)
            {
                speed = -speed;
                enemyT.position += Vector3.down * 0.5f;
                return;
            }
            if (enemy.position.y <= -5)
            {
                Time.timeScale = 0;
            }
        }
        */
    }
}
