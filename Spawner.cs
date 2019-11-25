using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool triggerSpawn = false;

    [SerializeField]
    private GameObject starkie;

    [SerializeField]
    private Transform jumpTrigger;

    [SerializeField]
    private Transform jumpPlatform;

    void Update()
    {
        if(triggerSpawn)
        {
            var IStarkie = Instantiate(starkie, transform.position, Quaternion.identity);
            IStarkie.GetComponent<StarkieData>().jumpTriggerToLookAt = jumpTrigger;
            triggerSpawn = false;
        }
    }
}
