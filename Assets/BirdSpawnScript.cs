using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawnScript : MonoBehaviour
{
    public GameObject bird;
    private float timer = 0;
    private float spawnRate;
    public LogicScript logic;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(0.5f, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnBird();
            timer = 0;
            spawnRate = Random.Range(0.5f, 2.5f);
        }
    }

    void spawnBird()
    {
        float lowestPoint = -5.5f;
        float highestPoint = 3.5f;
        if (!logic.gameIsOver)
        {
            Instantiate(bird, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
        
    }
}
