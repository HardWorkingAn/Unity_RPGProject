using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody characterRigidbody;
    float speedLog;
    //public Vector3 position;
    //public float Speed = 10;
    Vector3 velocity;
    float Timecheck = 0.0f;

    void Awake()
    {
        Application.targetFrameRate = 144; // 최대 144프레임 고정
    }
    // Start is called before the first frame update
    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();
        //position = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        velocity = characterRigidbody.velocity;
        speedLog = velocity.magnitude;
        /*
        if (speedLog <= 10)
        {
            
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
            {
                characterRigidbody.AddForce(-speed, 0, speed);
            }
            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
            {
                characterRigidbody.AddForce(speed, 0, speed);
            }
            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
            {
                characterRigidbody.AddForce(speed, 0, -speed);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
            {
                characterRigidbody.AddForce(-speed, 0, -speed);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                characterRigidbody.AddForce(-speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                characterRigidbody.AddForce(speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                characterRigidbody.AddForce(0, 0, speed);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                characterRigidbody.AddForce(0, 0, -speed);
            }
        }
        */
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        */






        Timecheck += Time.deltaTime;
        if (Timecheck >= 0.1f)
        {
            Timecheck = 0.0f;
            Debug.Log("Current Speed: " + speedLog);
        }

        /*
        position.x += Speed * Time.deltaTime * Input.GetAxisRaw("Horizontal");
        position.z += Speed * Time.deltaTime * Input.GetAxisRaw("Vertical");

        transform.position = position;
        */
    }
    void FixedUpdate()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Z = Input.GetAxisRaw("Vertical");

        float fall = characterRigidbody.velocity.y;
        
        characterRigidbody.velocity = new Vector3(X * speed, fall, Z * speed);


        Vector3 Rotation = new Vector3(X, 0, Z);
        if( !(X == 0 && Z == 0)) // 0 이면 아무것도 입력하지 않은 상태 만약 하나라도 움직이면 안쪽은 false 가 되고 !붙어져있으니 true 반환
        {
            transform.rotation = Quaternion.LookRotation(Rotation);
        }
        
    }

}
