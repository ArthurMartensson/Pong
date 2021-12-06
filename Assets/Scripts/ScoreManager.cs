using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoretext;
    public BallMovement ball;
    private float ballSpeed;
    private bool start = true;
    int p1score = 0, p2score = 0;
    public AudioClip scoreClip, gameOverClip;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreboard();
        ballSpeed = ball.speed;
    }

    public void Score(int player)
    {
        if (player == 1)
        {
            p1score++;
        }
        else if (player == 2)
        {
            p2score++;
        }
        UpdateScoreboard();
    }

    private void UpdateScoreboard()
    {
        scoretext.text = p1score + " - " + p2score;
        if (Mathf.Max(p1score, p2score) >= 3) // if(p1score >= 3 || p2scoere >= 3)
        {
            ball.speed = 0;
            scoretext.text += "\nGame Over!";
            AudioSource.PlayClipAtPoint(gameOverClip, Vector3.zero);
        }
        else if (!start)
        {
            ball.speed = 0;
            StartCoroutine(BallPause());
            AudioSource.PlayClipAtPoint(scoreClip, Vector3.zero);
        }
        start = false;
    }

    IEnumerator BallPause()
    {
        float t = Time.time;
        while (Time.time - t < 2)
            yield return null;
        ball.speed = ballSpeed;
        yield return null;
    }
}
