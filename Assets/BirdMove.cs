using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float moveSpeed = 7;
    public float leftDeadZone = -12;
    public float rightDeadZone = 12;
    public bool rightSide;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rightSide)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
            if (transform.position.x < leftDeadZone)
            {
                Destroy(gameObject);
                logic.loseHealth();
            }
        }
        else
        {
            transform.position = transform.position - (Vector3.left * moveSpeed) * Time.deltaTime;
            if (transform.position.x > rightDeadZone)
            {
                Destroy(gameObject);
                logic.loseHealth();
            }
        }
    }
}
