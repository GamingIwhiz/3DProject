using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarkieAttack : MonoBehaviour
{
    [SerializeField]
    private float delay;
    private float currentTime;

    private void Start()
    {
        currentTime = delay + Time.time;
    }

    void Update()
    {
        if(Time.time > currentTime)
        {
            Debug.Log("Attack Logic");
        }
    }
}
