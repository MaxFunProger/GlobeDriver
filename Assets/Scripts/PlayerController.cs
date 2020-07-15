using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveX;
    private float moveY;
    private float moveZ;
    public Transform globe;
    public Vector3 gravity;
    public float speed;
    public bool flag;
    public float force;
    void Start()
    {
        gravity = globe.position;
    }

    float absoluteRotation = 0;
    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.position += new Vector3(moveX, 0, moveZ);
        if (!flag)
        {
            transform.position += gravity;
        }
        else
        {
            transform.position -= gravity * force;
        }

        //transform.RotateAround(globe.position, new Vector3(moveX, 0, moveY), 1);

/*        if (Input.GetAxis("Horizontal") > 0)
            absoluteRotation += 0.1f;
        if (Input.GetAxis("Horizontal") < 0)
            absoluteRotation -= 0.1f;

        transform.RotateAround(globe.position, Vector3.up, absoluteRotation);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Globe"))
        {
            flag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Globe"))
        {
            flag = false;
        }
    }

}
