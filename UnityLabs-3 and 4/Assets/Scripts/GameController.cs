using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text ScoreText;
    public Button PlayAgainButton;
    public GameObject OneBallPrefab;
    public int Score;
    public bool GameOver = true;
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
            if (NumberOfBalls >= MaxBalls)
            {
                GameOver = true;
                PlayAgainButton.gameObject.SetActive(true);
            }
        }
    }

    public void StartGame()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("GameController"))
        {
            Destroy(ball);
        }

        Score = 0;
        NumberOfBalls = 0;
        PlayAgainButton.gameObject.SetActive(false);
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
    }
}
