using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    int up = 1;
    int right = 1;
    public AudioClip ceilFloorBounce, paddleBounce;
    public ScoreManager scoremanager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 4.75)
        {
            up = -1;
            AudioSource.PlayClipAtPoint(ceilFloorBounce, Vector3.zero);
        }
        if (transform.position.y <= -4.75)
        {
            up = 1;
            AudioSource.PlayClipAtPoint(ceilFloorBounce, Vector3.zero);
        }
        transform.Translate((up * Vector3.up + right * Vector3.right)
            * Time.deltaTime * speed);

        if (transform.position.x < -9.1)
        {
            transform.position = Vector3.zero;
            scoremanager.Score(2);
        }
        if (transform.position.x > 9.1)
        {
            transform.position = Vector3.zero;
            scoremanager.Score(1);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        right = -right;
        AudioSource.PlayClipAtPoint(paddleBounce, Vector3.zero);
    }
}
