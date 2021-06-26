using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiScript : MonoBehaviour
{
    public Text fpsText;
    public Text blocksText;

    public SpawnScript boxNum;

    private DateTime lastFrame;
    private float fpsNum;
    private float showNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        lastFrame = DateTime.Now;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        fpsNum++;
        if((DateTime.Now - lastFrame) > new TimeSpan(0, 0, 1))
        {
            showNum = fpsNum;
            fpsNum = 0;
            lastFrame = DateTime.Now;
        }

        fpsText.text = showNum.ToString();
        blocksText.text = boxNum.boxesNumbers.ToString();

    }
}
