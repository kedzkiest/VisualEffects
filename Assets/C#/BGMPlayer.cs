using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            audioSource.volume += 0.005f;
        }

        if (Input.GetKey(KeyCode.L))
        {
            audioSource.volume -= 0.005f;
        }
    }
}
