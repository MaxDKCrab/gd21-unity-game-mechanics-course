using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRb;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    
    void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        
        myRb.velocity = new Vector3(moveSpeed * moveInput, myRb.velocity.y, 0);

        //var jumpInput = Input.GetKeyDown(KeyCode.Space);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRb.AddForce(0, jumpForce, 0);
        }
    }
}
