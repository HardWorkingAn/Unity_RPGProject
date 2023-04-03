using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public GameObject Target;               // 카메라가 따라다닐 타겟

    public float offsetX = 0.0f;            // 카메라의 x좌표
    public float offsetY = 7.0f;           // 카메라의 y좌표
    public float offsetZ = -7.0f;          // 카메라의 z좌표

    public float CameraSpeed = 1.0f;       // 카메라의 속도
    Vector3 TargetPos;                      // 타겟의 위치

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("Character");
        transform.Rotate(45.0f, 0.0f, 0.0f);

        offsetX = 0.0f;
        offsetY = 7.0f;
        offsetZ = -7.0f;
    }
    
    // Update is called once per frame
    void Update()
    {

        
    }
    void FixedUpdate()
    {
        TargetPos = new Vector3(
             Target.transform.position.x + offsetX,
             Target.transform.position.y + offsetY,
             Target.transform.position.z + offsetZ
             );

        // 카메라의 움직임을 부드럽게 하는 함수(Lerp)
        //transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
        transform.position = TargetPos;

    }

}
