using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEsetss : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Click);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Hit);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Magic);
        }
    }
}
