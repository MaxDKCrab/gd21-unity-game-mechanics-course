using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private Collider collide;
    public bool GroundCheck()
    {
        Ray sphereCastRay = new Ray(transform.position, Vector3.down);
        bool isGrounded = Physics.SphereCast(sphereCastRay, collide.bounds.extents.x, collide.bounds.extents.y + 0.05f);
        return isGrounded;
    }
}
