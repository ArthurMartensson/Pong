using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed;
    public int player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string up_key, down_key;
        if (player == 1)
        {
            up_key = "w";
            down_key = "s";
        }
        else
        {
            up_key = "up";
            down_key = "down";
        }
        if (Input.GetKey(up_key))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(down_key))
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, -4, 4),
            transform.position.z);
    }
}
