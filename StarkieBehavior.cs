using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarkieBehavior : MonoBehaviour
{
    public enum Action {Run, Jump, Alert};

    public Action behavior = Action.Run;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Jump")
        {
            behavior = Action.Jump;
        }
        else if(other.tag == "Alert")
        {
            behavior = Action.Alert;
        }
    }
}
