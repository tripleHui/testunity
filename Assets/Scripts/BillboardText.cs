﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}
