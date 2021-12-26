﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CarController : MonoBehaviour
{
    float speed = 0;

    Vector2 startPos;

    Vector3 position;

    void Start()
    {
        position = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            startPos = Input.mousePosition;
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - startPos.x);
            this.speed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }
            
        transform.Translate(speed, 0, 0);
        this.speed *= 0.98f;
    }
}
