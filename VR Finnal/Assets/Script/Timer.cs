using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class Timer : MonoBehaviour
{
    public float timeValue = 240;

    public TextMeshProUGUI theTimer;

    public static Timer instance;

    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if (timeValue > 0 && gamemanagment.instance.gameOn == true)
        {
            timeValue -= Time.deltaTime;
        }
        else if (timeValue == 0)
        {
            gamemanagment.instance.GameEnd();
        }

        if (timeValue < 0)
        {
            timeValue = 0;
        }

        float minutes = Mathf.FloorToInt(timeValue / 60);
        float seconds = Mathf.FloorToInt(timeValue % 60);

        theTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
