using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarkieMovement : MonoBehaviour
{
    private bool jump = true;

    private void Start()
    {
        transform.LookAt(new Vector3(GetComponent<StarkieData>().jumpTriggerToLookAt.position.x, transform.position.y, GetComponent<StarkieData>().jumpTriggerToLookAt.position.z));
    }

    void Update()
    {
        if(GetComponent<StarkieBehavior>().behavior == StarkieBehavior.Action.Run)
        {
            GetComponent<Rigidbody>().MovePosition(transform.position + (transform.forward * Time.deltaTime * 5.0f));
            GetComponent<Animator>().SetBool("Run", true);
            GetComponent<Animator>().SetBool("Twist", false);
        }
        else if(GetComponent<StarkieBehavior>().behavior == StarkieBehavior.Action.Jump)
        {
            if (jump)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 800.0f, 0.0f), ForceMode.Impulse);
                jump = false;
            }
            GetComponent<Rigidbody>().MovePosition(transform.position + (transform.forward * Time.deltaTime * 5.0f));
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("Twist", true);
        }
        if(GetComponent<StarkieBehavior>().behavior == StarkieBehavior.Action.Alert)
        {

        }
    }
}
