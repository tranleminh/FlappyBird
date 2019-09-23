using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenRotation : MonoBehaviour
{
    public float duration;
    private Vector3 v = new Vector3(0, 0, -135);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DORotate(v, duration, RotateMode.FastBeyond360).SetRelative().SetEase(Ease.Linear);
    }
}
