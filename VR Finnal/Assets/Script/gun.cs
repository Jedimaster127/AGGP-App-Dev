using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;

    public Transform spawnSpot;

    public void Fire()
    {
        Instantiate(bullet, spawnSpot.position, spawnSpot.rotation);
    }
}
