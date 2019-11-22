using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private new Transform camera;

    [SerializeField]
    private Transform projectileExit;
    [SerializeField]
    private Transform bullet;

    private float currentTime;
    [SerializeField]
    private float delay;

    void Start()
    {
        currentTime = Time.time + delay;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time > currentTime)
            {
                Instantiate(bullet, projectileExit.position, Quaternion.Euler(90.0f, camera.eulerAngles.y, 0.0f));
                currentTime = Time.time + delay;
            }
        }
    }
}
