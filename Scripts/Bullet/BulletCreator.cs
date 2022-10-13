using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject bulletPrefab;
    private void Start()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);      
    }   
}
