using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCorrecter : MonoBehaviour
{
    public Transform spine;
    [SerializeField]
    private float spineCorrectionAngle;

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            spine.eulerAngles = new Vector3(0.0f, GetComponent<Movement>().camera.eulerAngles.y + spineCorrectionAngle, 0.0f);
        }
    }
}
