using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BulletMoving : MonoBehaviour
{
    public GameObject bullet;
    public float position = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullet.transform.DOMoveX(position, Random.Range(8, 12));
    }
}
