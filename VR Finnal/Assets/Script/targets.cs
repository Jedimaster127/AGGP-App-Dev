using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targets : MonoBehaviour
{
    public int speed = 15;

    public int pointCost = 1;

    public static targets instance;

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.forward * Time.deltaTime * speed;

        Destroy(gameObject, 3);

        if(gamemanagment.instance.gameOn == false)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            gamemanagment.instance.score += pointCost;
        }
    }
}
