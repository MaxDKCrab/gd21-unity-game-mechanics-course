using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private Collider collide;
    public bool GroundCheck()
    {
        Ray sphereCastRay = new Ray(transform.position, Vector3.down);
        bool isGrounded = Physics.SphereCast(sphereCastRay, collide.bounds.extents.x, collide.bounds.extents.y);
        return isGrounded;
    }

    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawSphere(transform.position + Vector3.down * collide.bounds.extents.y, collide.bounds.extents.x);
    // }
}
