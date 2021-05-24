using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;

  public float speed = 5;
    public int score;
    public int hiscore;
    public Text scoretext;
    public Text hiscoretext;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hiscoreText;
    public AudioSource shotSound;
    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
        shotSound.Play();
      myRigidbody2D.velocity = Vector2.up * speed; 
      Debug.Log("Wwweeeeee");
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            Score playerscore = GetComponent<Score>();
            playerscore.score += 10;
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            Score playerscore = GetComponent<Score>();
            playerscore.score += 20;
        }
        if (collision.gameObject.tag == "Enemy3")
        {
            Score playerscore = GetComponent<Score>();
            playerscore.score += 50;
        }
        if (collision.gameObject.tag == "Enemy4")
        {
            Score playerscore = GetComponent<Score>();
            playerscore.score += 100;
        }
    }
    
}
