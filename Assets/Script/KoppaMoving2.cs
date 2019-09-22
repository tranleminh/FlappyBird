using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoppaMoving2 : MonoBehaviour
{
    public Animator anim;
    private bool rotate = false;
    public float speed;
    private Vector3 currentDirection = Vector3.left;
    private Rigidbody2D rigidbody;

    private void move()
    {
        transform.position += currentDirection * speed * Time.deltaTime;
    }

    private void changeDirection()
    { 
        
        if (currentDirection == Vector3.left)
        {
            currentDirection = Vector3.right;
            speed = speed / 4;
        }
        else
        {
            currentDirection = Vector3.left;
            speed = speed * 4;
        }
    }

    void FixedUpdate()
    { 
        //Ignore gravity 
        rigidbody.AddRelativeForce(Vector3.up * (rigidbody.mass * Mathf.Abs(Physics.gravity.y)));
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        anim.SetBool("rotate", rotate);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pipe")
        {
            rotate = !rotate;
            anim.SetBool("rotate", rotate);
            changeDirection();
        }
    }
}
