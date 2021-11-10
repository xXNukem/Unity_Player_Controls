using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0,50),Tooltip("Current speed")]
    private float speed = 10.0f;

    [SerializeField, Range(0, 50), Tooltip("Turn Speed")]
    private float turnSpeed = 10.0f;

    [SerializeField]
    private float horizontalInput;

    [SerializeField]
    private float verticalInput;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        ///S=S0 + v*t*(direction)
        this.transform.Translate(this.speed*Time.deltaTime*Vector3.forward*verticalInput);
        this.transform.Rotate(turnSpeed * Time.deltaTime * Vector3.up * horizontalInput);
    }
}
