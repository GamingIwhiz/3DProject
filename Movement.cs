using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public new Transform camera;
    [SerializeField]
    private Transform cameraTarget;
    [SerializeField]
    private float speed = 0;

    private float x;
    private float y;

    [SerializeField]
    private bool pause = false;

    void Update()
    {
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");

        if(Input.GetKeyDown(KeyCode.P))
        {
            pause = !pause;
        }

        if (!pause)
        {
            camera.LookAt(cameraTarget.position);
            camera.position = cameraTarget.position + camera.TransformDirection(new Vector3(-x, -y, -3.0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += (transform.forward * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0.0f, camera.eulerAngles.y, 0.0f);
            GetComponent<Animator>().SetLayerWeight(1, 0);
            GetComponent<Animator>().SetLayerWeight(2, 1);
            GetComponent<Animator>().SetLayerWeight(3, 1);
        }
        else
        {
            GetComponent<Animator>().SetLayerWeight(1, 1);
            GetComponent<Animator>().SetLayerWeight(2, 0);
            GetComponent<Animator>().SetLayerWeight(3, 0);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += (transform.right * speed * Time.deltaTime);
        }

        if(Input.GetMouseButton(0))
        {
            GetComponent<Animator>().SetLayerWeight(3, 1);
        }
    }
}
