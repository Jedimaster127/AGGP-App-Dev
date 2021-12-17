using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int bulletSpeed = 30;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Gun")
        {
            Destroy(gameObject);
        }
    }
}
