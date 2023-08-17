using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 dir = new Vector3(0, mouseX, 0);

        //                       ↓방향  ↓속도  ↓시간 
        transform.eulerAngles += dir * speed * Time.deltaTime;
    }
}
