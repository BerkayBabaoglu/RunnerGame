using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;
    bool canJump;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            // jump

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
