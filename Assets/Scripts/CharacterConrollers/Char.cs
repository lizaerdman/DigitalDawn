using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Terrain.Data;
using Terrain.Visuals;
using TypeSafeEventManager.Events;

public class Char : PhysicsObject
{
    bool isWalking;
    bool isGrounded;
    bool facingRight;

    protected override void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            facingRight = true;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            facingRight = false;
        }

        if (!facingRight)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
