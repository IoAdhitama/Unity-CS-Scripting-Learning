using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterfaces : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * 5 * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        Instantiate(bulletPrefab, transform.position + new Vector3(0, 0, 1), transform.rotation);
    }
}
