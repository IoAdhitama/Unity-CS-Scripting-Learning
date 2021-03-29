using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateSecondDemo : MonoBehaviour
{
    delegate void Delegate();
    Delegate exampleDelegate;

    Vector3 targetLocation;

    // Start is called before the first frame update
    void Start()
    {
        exampleDelegate += SetTargetLocation;
        exampleDelegate += ChangeColor;

        exampleDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void SetTargetLocation()
    {
        targetLocation = new Vector3(-10, 0, 10);
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void Move()
    {
        transform.MoveTo(targetLocation, 1f);
    }
}
