using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBehaviorStatics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the "unit"
        if (gameObject.CompareTag("Player"))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        else if (gameObject.CompareTag("Enemy"))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }

        // Destroy the object if it is out of bounds
        if (gameObject.transform.position.x > 10 || gameObject.transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
