using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    public int Score;
    public bool GameOver = false;
    public int NumberOfBalls;
    public int MaxBalls = 15;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AddABall), 1.5f, 1);
    }

    public void ClickedOnBall()
    {
        Score++;
        NumberOfBalls--;
    }

    void AddABall()
    {
        if (!GameOver)
        {
            Instantiate(OneBallPrefab);
            NumberOfBalls++;
        }

        if (NumberOfBalls == MaxBalls)
        {
            GameOver = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
