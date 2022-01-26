using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Collider collider;
    [SerializeField] private Rigidbody myRb;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    private float extraHeight = 0.1f;
    
    void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        
        myRb.velocity = new Vector3(moveSpeed * moveInput, myRb.velocity.y, 0);

        Ray sphereCastRay = new Ray(transform.position, Vector3.down);
        bool isGrounded = Physics.SphereCast(sphereCastRay, collider.bounds.extents.x, collider.bounds.extents.y + 0.05f);
        
        
        if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        {
            myRb.AddForce(0, jumpForce, 0);
        }
    }

}
