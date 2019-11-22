using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;

    void Update()
    {
        transform.position += (transform.up * Time.deltaTime * speed);
    }
}
