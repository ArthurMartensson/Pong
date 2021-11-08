using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey("s"))
            transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
