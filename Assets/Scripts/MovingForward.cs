using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    private float _speed = 3f;

    void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
}
