using System.Collections;
using System.Collections.Generic;
using System.Text;
using Cinemachine;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float xRotateSpeed;
    public float yRotateSpeed;
    public float zRotateSpeed;
    public float moveSpeed;

    public int mode;

    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 1)
        {
            transform.Rotate(xRotateSpeed * Time.deltaTime, yRotateSpeed * Time.deltaTime,
                zRotateSpeed * Time.deltaTime);
        }

        if (mode == 2)
        {
            transform.position = new Vector3(moveSpeed * Time.deltaTime * Mathf.Cos(Time.time), 0,
                moveSpeed * Time.deltaTime * Mathf.Sin(Time.time));
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (vCam1.Priority >= vCam2.Priority)
            {
                vCam1.Priority = 0;
                vCam2.Priority = 10;
            }
            else
            {
                vCam1.Priority = 10;
                vCam2.Priority = 0;
            }
        }
    }
}
