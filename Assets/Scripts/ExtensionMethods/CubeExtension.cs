using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExtension : MonoBehaviour
{
    public Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        transform.ResetTransformation();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != destination)
        {
            transform.MoveTo(destination, 5);
        }
    }
}
