using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EnemyBullet : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * -speed;

        if (bullet.position.y <= 10)
        {
            Destroy(bullet.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameOver.isPlayerDead = true;
        }
        else if (collision.tag == "Barricade")
        {
            GameObject playerBase = collision.gameObject;
            BarricadeHealth baseHealth = playerBase.GetComponent<BarricadeHealth>();
            baseHealth.health -= 1;
            Destroy(gameObject);
        }
    }
}
