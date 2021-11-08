using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    int up = 1;
    int right = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 4.75)
            up = -1;
        if (transform.position.y <= -4.75)
            up = 1;
        transform.Translate((up * Vector3.up + right * Vector3.right)
            * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        right = -right;
    }
}
