using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class layerBehaviour : MonoBehaviour
{
    private float switchTime;

    private int rand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switchTime <= 0)
        {
            rand = Random.Range(0, 100);
            switchTime = 3;
        }


        if (rand < 50)
        {
            gameObject.transform.Rotate(0, 5.0f, 0);
            switchTime -= Time.deltaTime;
        }
        else
        {
            gameObject.transform.Rotate(0, -5.0f, 0);
            switchTime -= Time.deltaTime;
        }
    }
}
