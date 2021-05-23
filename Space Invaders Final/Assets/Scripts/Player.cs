using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    private Animator playerAnimator;
    public Rigidbody2D rb;
    public float speed = 10.0f;

    public Transform shottingOffset;
    public Vector2 movement;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            playerAnimator.SetTrigger("Shoot");
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 3f);

        }
        movement = new Vector2(Input.GetAxis("Horizontal"), 0);

    }


    void FixedUpdate()
    {
        PlayerMovement(movement);
    }

    void PlayerMovement(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));

    }
}