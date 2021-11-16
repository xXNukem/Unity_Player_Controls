using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed=20;
    public float maxSpeed=100;
    public float minSpeed = 0;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;

    public float elevation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //horizontalInput = Input.GetAxis("Horizontal");
        //verticalInput = Input.GetAxis("Vertical");


        transform.position += transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            if(speed <= maxSpeed)
            {
                speed++;
            }
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (speed >= minSpeed)
            {
                speed--;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
        }

    }
}
