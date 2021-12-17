using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class gamemanagment : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    public static gamemanagment instance;

    public Transform startTargetSpawn;

    public GameObject startTarget;

    public bool gameOn = false;

    public List<GameObject> gameTargets = new List<GameObject>(3);

    public List<GameObject> spawnSpot = new List<GameObject>(2);

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void GameStart()
    {
        gameOn = true;

        InvokeRepeating("SpawnTarget", 1, .5f);

        if (score != 0)
        {
            score = 0;
        }

    }

    public void GameEnd()
    {
        gameOn = false;

        CancelInvoke("SpawnTarget");

        Timer.instance.timeValue = 240;

        Instantiate(startTarget, startTargetSpawn.position, startTargetSpawn.rotation);
    }

    public void SpawnTarget()
    {

        int num = Random.Range(1, 101);

        int spawn = Random.Range(0, 2);

        scoreText.text = score.ToString();

        if (num <= 75)
        {
            ScoreLow(spawn);
        }
        else if (num > 75 && num <= 90)
        {

            ScoreMedium(spawn);
        }
        else if (num > 90 && num <= 100)
        {
            ScoreHigh(spawn);
        }
    }

    public void ScoreLow(int spawn)
    {
        Instantiate(gameTargets[0], spawnSpot[spawn].transform.position, spawnSpot[spawn].transform.rotation);
    }

    public void ScoreMedium(int spawn)
    {        
        Instantiate(gameTargets[1], spawnSpot[spawn].transform.position, spawnSpot[spawn].transform.rotation);
    }

    public void ScoreHigh(int spawn)
    {       
        Instantiate(gameTargets[2], spawnSpot[spawn].transform.position, spawnSpot[spawn].transform.rotation);
    }
}
