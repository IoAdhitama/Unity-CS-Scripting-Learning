using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleInterfaces : MonoBehaviour, IDamageable
{
    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(new Vector3(90, 0, 90) * Time.deltaTime);
    }

    public void Damage()
    {
        Destroy(gameObject);
    }
}
