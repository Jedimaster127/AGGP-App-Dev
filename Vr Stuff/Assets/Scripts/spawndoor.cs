using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class spawndoor : MonoBehaviour
{
    public Rigidbody door;

    public GameObject spawnSpot;

    public GameObject text;

    GameObject existingDoor;

    private void Update()
    {
        existingDoor = GameObject.FindWithTag("Door");
    }

    public void SpawnDoor()
    {

        if(existingDoor == null)
        {
            Instantiate(door, spawnSpot.transform.position, spawnSpot.transform.rotation);
        }
        else
        {
            StartCoroutine(DoorHere());
        }
    }

    public IEnumerator DoorHere()
    {
        text.SetActive(true);
        yield return new WaitForSecondsRealtime(5);
        text.SetActive(false);
    }
}
