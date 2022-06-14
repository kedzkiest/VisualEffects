using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEmitter : MonoBehaviour
{
    public GameObject ball;
    public GameObject target;
    public float minSpan;
    public float maxSpan;

    private GameObject emittedBall;
    private float currentTime = 0f;
    private float span;
    private bool emit;

    // Start is called before the first frame update
    void Start()
    {
        span = (minSpan + maxSpan) / 2.0f;
        emit = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > span && emit)
        {
            emittedBall = Instantiate(ball, gameObject.transform.position, Quaternion.identity);
            currentTime = 0f;
        }

        int rand = Random.Range(0, 100);
        if (rand < 5)
        {
            span = Random.Range(minSpan, maxSpan);
        }

        if (Input.GetKey(KeyCode.M))
        {
            emit = true;
        }

        if (Input.GetKey(KeyCode.L))
        {
            emit = false;
        }
    }
}
