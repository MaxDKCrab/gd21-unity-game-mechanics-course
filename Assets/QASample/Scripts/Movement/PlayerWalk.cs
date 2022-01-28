using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private PlayerInput playerInput;
    void Update()
    { 
        Move();   
    }
    private void Move()
    {
        
        rb.velocity = new Vector3(walkSpeed * playerInput.walkInput, rb.velocity.y, 0);
    }
}
