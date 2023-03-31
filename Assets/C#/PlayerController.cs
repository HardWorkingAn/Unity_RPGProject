using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody characterRigidbody;
    float speedLog;
    //public Vector3 position;
    //public float Speed = 10;
    Vector3 velocity;
    float Timecheck = 0.0f;

    void Awake()
    {
        Application.targetFrameRate = 100; // 최대 100프레임 고정
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
}
