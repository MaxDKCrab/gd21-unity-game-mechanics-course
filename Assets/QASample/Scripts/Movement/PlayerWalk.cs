using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private CommandContainer commandContainer;
    void Update()
    { 
        Move();   
    }
    private void Move()
    {
        rb.velocity = new Vector3(walkSpeed * commandContainer.walkCommand, rb.velocity.y, 0);
    }
}
