using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImediateJump : MonoBehaviour
{
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private CommandContainer commandContainer;
    void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (commandContainer.jumpCommandDown & groundChecker.GroundCheck())
        {
            rb.AddForce(0, jumpForce, 0);
        }
    }
   
}
