
using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float walkInput;
    public bool jumpInputDown;
    public bool jumpInputUp;
    public bool jumpInput;
    private void Update()
    {
        GetInput();
    }
    
    private void GetInput()
    {
        walkInput = Input.GetAxis("Horizontal");
        jumpInputDown = Input.GetKeyDown(KeyCode.Space);
        jumpInput = Input.GetKey(KeyCode.Space);
        jumpInputUp = Input.GetKeyUp(KeyCode.Space);
    }
}
