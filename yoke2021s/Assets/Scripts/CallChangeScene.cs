﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    ToNextScene toNextScene;

public class CallChangeScene : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        toNextScene = GetComponent<ToNextScene>();
    }
}

// Update is called once per frame
void Update()
  {
    if (Input.GetButtonDown("Next"))
    {
        toNextScene.ChangeScene();
    }
  }