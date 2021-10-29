using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAspectScript : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        float desired_aspect = 16f / 9;
        Camera cam = GetComponent<Camera>();
        float screen_aspect = cam.aspect;
        if (screen_aspect < desired_aspect)
        {
            float y = 0.5f - screen_aspect / (2 * desired_aspect); float h = screen_aspect / desired_aspect; cam.rect = new Rect(0, y, 1, h);
        }
        else
        {
            float x = 0.5f - desired_aspect / (screen_aspect * 2);
            float w = desired_aspect / screen_aspect; cam.rect = new Rect(x, 0, w, 1);
        }
    }
}
