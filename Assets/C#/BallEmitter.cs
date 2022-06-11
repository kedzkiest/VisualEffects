using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEmitter : MonoBehaviour
{
    public GameObject ball;
    public GameObject target;
    public float span;

    private GameObject emittedBall;
    private float currentTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > span)
        {
            emittedBall = Instantiate(ball, gameObject.transform.position, Quaternion.identity);
            currentTime = 0f;
        }

        int rand = Random.Range(0, 100);
        if (rand < 5)
        {
            span = Random.Range(0.5f, 1.5f);
        }
    }
}
