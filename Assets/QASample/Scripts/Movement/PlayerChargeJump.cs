using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerChargeJump : MonoBehaviour
{
    [SerializeField] private GroundChecker groundChecker;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float minJumpForce = 300f;
    [SerializeField] private float maxJumpForce = 800f;
    [SerializeField] private float jumpChargeTime = 1f;
    [SerializeField] private PlayerInput playerInput;
    private float chargeProgress;
    void Update()
    {
        Jump();
    }
    private void Jump()
    {

        
        if (playerInput.jumpInput)
        {
            chargeProgress += Time.deltaTime / jumpChargeTime;
        }
        
        if (playerInput.jumpInputUp)
        {
            var jumpForce = Mathf.Lerp(minJumpForce, maxJumpForce, chargeProgress);
            chargeProgress = 0f;

            if (groundChecker.GroundCheck())
            {
                rb.AddForce(0, jumpForce, 0);
            }
        }
    }
}
