using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject BallPrefab;

    // The number of frames to wait before spawning another Ball
    public int SpawnTime = 50;

    // We will use this to count how many frames have elapsed since the last Ball creation
    private int counter = 0;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // If we can spawn the Ball
        if (counter > SpawnTime)
        {
            // We generate a random x coordinate for the Ball
            float xPosition = Random.Range(-18, 18);

            // We instantiate a new Ball at the generated axis while keeping the Y and Z axes constant
            var ball = Instantiate(BallPrefab, transform.position + new Vector3(xPosition, 0, 0), Quaternion.Euler(0, 180, 0), gameObject.transform);

            // We make sure that the Ball is properly scaled
            ball.transform.localScale = new Vector3(4, 4, 4);

            // We tell the program to destroy the Ball after 10 seconds have passed and reset the counter
            Destroy(ball, 10);
            counter = 0;
        }
        else
        {
            counter++;
        }

    }
}