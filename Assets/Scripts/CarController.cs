using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject Sphere;

    private Vector3 sphereCenter;
    private float radius;

    void Start()
    {
        sphereCenter = Sphere.transform.position;
        radius = Vector3.Distance(transform.position, sphereCenter);
    }

    float firstAngle = Mathf.PI / 2;
    float secondAngle = 1;
    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        if (moveX > 0)
            firstAngle = (firstAngle + 0.01f) % (2 * Mathf.PI);
        else if (moveX < 0)
            firstAngle = (firstAngle - 0.01f) % (2 * Mathf.PI);
        if (moveY != 0)
            secondAngle = (secondAngle - 0.01f) % (2 * Mathf.PI);
        else if (moveY < 0)
            secondAngle = (secondAngle + 0.01f) % (2 * Mathf.PI);

        transform.position = CalculatePosition(firstAngle, secondAngle);
    }

    private Vector3 CalculatePosition(float theta, float phi)
    {
        float x = sphereCenter.x + radius * Mathf.Sin(theta) * Mathf.Cos(phi);
        float y = sphereCenter.y + radius * Mathf.Sin(theta) * Mathf.Sin(phi);
        float z = sphereCenter.z + radius * Mathf.Cos(theta);
        return new Vector3(x, y, z);
    }
}
