using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateFirstDemo : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate exampleDelegate;

    Vector3 targetLocation;

    // Start is called before the first frame update
    void Start()
    {
        exampleDelegate = SetX;
        exampleDelegate(10);

        exampleDelegate = SetZ;
        exampleDelegate(10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.MoveTo(targetLocation, 1f);
    }

    void SetX(int num)
    {
        targetLocation.x = num;
    }

    void SetZ(int num)
    {
        targetLocation.z = num;
    }

}
