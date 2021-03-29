using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCoroutine : MonoBehaviour
{
    public Vector3 target;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Movement(target));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Movement(Vector3 target)
    {
        while(Vector3.Distance(transform.position, target) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);

            yield return null;
        }
    }
}
