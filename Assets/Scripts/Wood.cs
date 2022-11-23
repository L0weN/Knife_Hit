using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    [SerializeField]private float speed = 0.5f;

    private void Update()
    {
        transform.Rotate(0f, speed, 0f);
    }
}
