﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = -10f;
    [SerializeField] float maxX = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width*screenWidthInUnits;
         Vector2 paddlePos = new Vector2(mousePosInUnits,transform.position.y);
         paddlePos.x = Mathf.Clamp(mousePosInUnits,minX,maxX);
         transform.position = paddlePos; 

    }
}
