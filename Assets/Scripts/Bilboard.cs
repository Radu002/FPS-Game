using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilboard : MonoBehaviour
{
    Camera cam;

    private void Update()
    {
        if (cam == null)
            cam = FindObjectOfType<Camera>();

        if (cam == null)
            return;

        transform.LookAt(cam.transform);
        transform.Rotate(Vector3.up * 180);
    }
}
