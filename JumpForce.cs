using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForce : MonoBehaviour
{
    [SerializeField]
    private float force;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Platform")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, force, 0.0f), ForceMode.Impulse);
        }
    }
}
