using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getCoinScript : MonoBehaviour
{
    public GameObject coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        Destroy(this.coin);        
    }
}
