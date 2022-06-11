using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBahaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(0, 100);

        if (rand < 10)
        {
            gameObject.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(-8.0f, 8.0f),
                Random.Range(-8.0f, 8.0f));
        }
    }
}
