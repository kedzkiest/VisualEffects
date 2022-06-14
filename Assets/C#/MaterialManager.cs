using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public GameObject ball;

    public Material bright;

    public Material normal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            ball.GetComponent<Renderer>().material = bright;
        }

        if (Input.GetKey(KeyCode.N))
        {
            ball.GetComponent<Renderer>().material = normal;
        }
    }
}
