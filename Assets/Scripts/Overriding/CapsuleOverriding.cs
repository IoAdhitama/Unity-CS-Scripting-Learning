// This is the base class. See BlueOverriding.cs and RedOverriding.cs for the child classes.
// See OverridingScene for usage of this class (and its child).
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleOverriding : MonoBehaviour
{
    protected float speed;
    protected Vector3 movement;
    public GameObject followTarget;
    protected int i = 0;

    private void Update()
    {
        transform.Translate(Move() * Time.deltaTime);
    }

    public CapsuleOverriding()
    {
        speed = 1f;
    }

    // Default behavior: Move forward
    public virtual Vector3 Move()
    {
        if (i == 0)
        {
            Debug.Log("The capsule moves.");
            i++;
        }
        movement = Vector3.forward;
        return movement;
    }
}
