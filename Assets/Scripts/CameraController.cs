﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    private Vector3 offset;
    void Start()
    {
        offset = -player.position + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
