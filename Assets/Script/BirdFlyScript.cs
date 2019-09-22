using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BirdFlyScript : MonoBehaviour
{

    /**********Attributes and global variables declared here***********/
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If mouse clicked then jump
        if (Input.GetMouseButtonDown(0) && velocity > 0)
        {
            rb.velocity = Vector2.up * velocity;
            //rb.DOJump(jumpPoint, 1, 1, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
        velocity = -1;
    }
}
