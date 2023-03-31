using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    public GameObject Target;               // ī�޶� ����ٴ� Ÿ��

    public float offsetX = 0.0f;            // ī�޶��� x��ǥ
    public float offsetY = 5.0f;           // ī�޶��� y��ǥ
    public float offsetZ = -5.0f;          // ī�޶��� z��ǥ

    public float CameraSpeed = 10.0f;       // ī�޶��� �ӵ�
    Vector3 TargetPos;                      // Ÿ���� ��ġ

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find("Character");
        transform.Rotate(45.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = new Vector3(
             Target.transform.position.x + offsetX,
             Target.transform.position.y + offsetY,
             Target.transform.position.z + offsetZ
             );

        // ī�޶��� �������� �ε巴�� �ϴ� �Լ�(Lerp)
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
        
    }
    private void LateUpdate()
    {
        
    }

}