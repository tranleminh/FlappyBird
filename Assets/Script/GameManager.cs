using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        PipeMoving.stopMovingPipe();
        PipeGenerating.stopGeneratingPipe();
        Time.timeScale = 1;
        DOTween.To(() => Time.timeScale, x => Time.timeScale = x, 0, 3);
    }
}
