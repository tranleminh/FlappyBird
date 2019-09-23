using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BulletMoving : MonoBehaviour
{
    public float position = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOMoveX(position, Random.Range(10, 15));
    }
}
