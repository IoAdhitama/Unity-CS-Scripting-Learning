using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueOverriding : CapsuleOverriding
{
    public BlueOverriding()
    {
        speed = 1.25f;
    }

    // Override to also specify the speed it is moving
    public override Vector3 Move()
    {
        base.Move();
        if (i == 1)
        {
            Debug.Log("The blue capsule moves forward at a certain speed.");
            i++;
        }
        movement = Vector3.forward * speed;
        return movement;
    }
}
