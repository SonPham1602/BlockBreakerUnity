﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    Level level;
    private void Start() {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        AudioSource.PlayClipAtPoint(breakSound,Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
        
   }
}
