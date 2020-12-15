using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] Rigidbody2D bullet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.AddForce(transform.forward * 200);
        }
    }
}
