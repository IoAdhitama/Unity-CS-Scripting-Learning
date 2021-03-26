using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedOverriding : CapsuleOverriding
{
    public RedOverriding()
    {
        speed = 1.3f;
    }

    // Red's movement will be to follow blue at a certain speed
    public override Vector3 Move()
    {
        base.Move();
        if (i == 1)
        {
            Debug.Log("The red capsule moves to follow the blue capsule.");
            i++;
        }
        movement = (followTarget.transform.position - transform.position).normalized * speed;
        return movement;
    }
}
