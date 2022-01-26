using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Collider collider;
    public Rigidbody myRb;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    private float extraHeight = 0.1f;
    
    void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        
        myRb.velocity = new Vector3(moveSpeed * moveInput, myRb.velocity.y, 0);

        bool isGrounded = Physics.Raycast(collider.bounds.center, Vector3.down, collider.bounds.extents.y + extraHeight);
        
        if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        {
            myRb.AddForce(0, jumpForce, 0);
        }
    }

}
