﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    CameraControl cameracontrol;
    [SerializeField] bool truee = false;
    // Start is called before the first frame update
    void Start()
    {
        cameracontrol = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraControl>();
    }

    // Update is called once per frame
    void Update()
    {
        cameracontrol.Atacked = truee;
    }
}
