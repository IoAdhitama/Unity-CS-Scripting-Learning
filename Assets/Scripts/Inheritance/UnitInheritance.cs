using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// All units move at a certain speed.
public class UnitInheritance : MonoBehaviour 
{
    public float moveSpeed;

    private void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
