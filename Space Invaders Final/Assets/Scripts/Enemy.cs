using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    private Transform enemyHolder;
    public float speed;
    public GameObject bullet;
    public TextMeshProUGUI winText;
    public float rate = 0.997f;
    public AudioSource enemyBoom;
    public AudioSource enemyShoot;

    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("EnemyMovement", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
    }

    void EnemyMovement()
    {
        enemyHolder.position += Vector3.right * speed;

        foreach (Transform enemy in enemyHolder)
        {
            if (enemy.position.x < -10.5 || enemy.position.x > -10.5)
            {
                speed = -speed;
                enemyHolder.position += Vector3.down * 0.05f;
                return;
            }

            if (Random.value > rate)
            {
                Instantiate(bullet, enemy.position, enemy.rotation);
                enemyShoot.Play();
            }

            if (enemy.position.y <= 10)
            {
                GameOver.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("EnemyMovement", 0.1f, 0.25f);
        }

        if (enemyHolder.childCount == 0)
        {
            winText.enabled = true;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Animator>().SetTrigger("Death");
        Destroy(collision.gameObject); // destroy bullet
        Debug.Log("Ouch!");
    }
}
