using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInterfaces : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit an Object");
        IDamageable damageable = other.GetComponent<IDamageable>();
        if (damageable != null)
        {
            damageable.Damage();
            Destroy(gameObject);
        }

    }


}
