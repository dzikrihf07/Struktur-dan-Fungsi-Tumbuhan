﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void reset(){
        PlayerPrefs.SetInt ("skor", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
