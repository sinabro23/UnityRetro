using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotateSpeed = 60f;

    void Update()
    {
        transform.Rotate(0.0f, RotateSpeed * Time.deltaTime, 0.0f);
    }
}
