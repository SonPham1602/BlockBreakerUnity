﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour
{
    SceneLoader sceneLoader;
    [SerializeField] int breakableBlocks;
    // Start is called before the first frame update
    private void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocks<=0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
