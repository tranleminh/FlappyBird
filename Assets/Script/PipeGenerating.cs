using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerating : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject Pipe;
    public float height;
    private static bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 5);
            timer = 0;
        }
        if (!gameOver)
            timer += Time.deltaTime;
    }

    public static void stopGeneratingPipe()
    {
        gameOver = true;
    }
}
