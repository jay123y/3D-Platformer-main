using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    // Reference to the bullet prefab
    public GameObject bulletPrefab;
    
    // Reference to the spawn point for the bullet
    public Transform bulletSpawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
void Shoot(){
    Instantiate(bulletPrefab,bulletSpawnPoint.position,bulletSpawnPoint.rotation);
}
}
