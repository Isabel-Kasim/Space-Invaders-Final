using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;

  public float speed = 5;
    public int score;
    public int hiscore;
    public Text scoretext;
    public Text hiscoretext;
    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      Debug.Log("Wwweeeeee");
    }
    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            score = score + 10;
            hiscore += score;
            scoretext.text = score.ToString();
            hiscoretext.text = hiscore.ToString();
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            score = score + 30;
            hiscore += score;
            scoretext.text = score.ToString();
            hiscoretext.text = hiscore.ToString();
        }
        if (collision.gameObject.tag == "Enemy3")
        {
            score = score + 50;
            hiscore += score;
            scoretext.text = score.ToString();
            hiscoretext.text = hiscore.ToString();
        }
        if (collision.gameObject.tag == "Enemy4")
        {
            score = score + 100;
            hiscore += score;
            scoretext.text = score.ToString();
            hiscoretext.text = hiscore.ToString();
        }
    }
    */
}
