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

    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vCam1.transform.Rotate(xRotateSpeed * Time.deltaTime, yRotateSpeed * Time.deltaTime,
                zRotateSpeed * Time.deltaTime);


        vCam2.transform.position = new Vector3(vCam2.transform.position.x + moveSpeed * Time.deltaTime * Mathf.Cos(Time.time), 0,
                vCam2.transform.position.z + moveSpeed * Time.deltaTime * Mathf.Sin(Time.time));


        if (Input.GetKey(KeyCode.Alpha1))
        {
            vCam1.Priority = 10;
            vCam2.Priority = 9;
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            vCam1.Priority = 9;
            vCam2.Priority = 10;
        }
    }
}
