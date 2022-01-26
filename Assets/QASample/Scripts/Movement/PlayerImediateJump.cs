using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImediateJump : MonoBehaviour
{
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 500f;
    void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) & groundChecker.GroundCheck())
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }
   
}
