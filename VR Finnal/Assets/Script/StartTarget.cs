using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTarget : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            gamemanagment.instance.GameStart();
        }
    }
}
