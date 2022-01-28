
using System;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float walkInput { get; private set; }
    public bool jumpInputDown { get; private set; }
    public bool jumpInputUp { get; private set; }
    public bool jumpInput { get; private set; }
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
