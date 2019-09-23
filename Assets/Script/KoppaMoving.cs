using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KoppaMoving : MonoBehaviour
{
    public Animator anim;
    private bool rotate = false;
    public float duration = 2;
    private float timer = 0;
    private bool spinlock = false;
    private int position = -1;

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("rotate", rotate);

        // Create a new Sequence.
        // We will set it so that the whole duration is 6
        Sequence s = DOTween.Sequence();
        // Add an horizontal relative move tween that will last the whole Sequence's duration
        s.Append(transform.DOMoveX(position, duration).SetRelative().SetEase(Ease.InOutQuad));
        // Set the whole Sequence to loop infinitely forward and backwards
        s.SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > duration - 0.15 && timer < duration)
        {
            if (!spinlock)
            {
                rotate = !rotate;
                anim.SetBool("rotate", rotate);
                spinlock = true;
            }
        }
        if (timer > duration)
        {
            if (spinlock)
            {
                rotate = !rotate;
                anim.SetBool("rotate", rotate);
                timer = 0;
                spinlock = false;
            }
            
        }
        timer += Time.deltaTime;
    }
}
