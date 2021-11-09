using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0,50),Tooltip("Current speed")]
    private float speed = 5.0f;


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
        ///S=S0 + v*t*(direction)
        this.transform.Translate(this.speed*Time.deltaTime*Vector3.forward);
    }
}
