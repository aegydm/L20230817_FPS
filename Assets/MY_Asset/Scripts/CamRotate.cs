using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//마우스를 따라 캠이 회전한다
//속성: 입력, X, Y, 속도
public class CamRotate : MonoBehaviour
{
    public float speed = 100f;
    float mx = 0;
    float my = 0;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        mx += mouseX * speed * Time.deltaTime;
        my += mouseY * speed * Time.deltaTime;

        my = Mathf.Clamp(my, -90f, 90f);

        Vector3 dir = new Vector3 (-my, mx, 0);

        //                       ↓방향  ↓속도  ↓시간 
        transform.eulerAngles = dir ;
    }

}
