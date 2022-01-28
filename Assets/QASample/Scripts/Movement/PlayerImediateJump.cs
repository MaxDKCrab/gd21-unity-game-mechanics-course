using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImediateJump : MonoBehaviour
{
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private PlayerInput playerInput;
    void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (playerInput.jumpInputDown & groundChecker.GroundCheck())
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }
   
}
