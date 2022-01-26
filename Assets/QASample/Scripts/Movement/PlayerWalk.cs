using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private Rigidbody rb;
    void Update()
    { 
        Move();   
    }
    private void Move()
    {
        var moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(walkSpeed * moveInput, rb.velocity.y, 0);
    }
}
