using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject boxes;

    public int boxesNumbers = 0;

    private DateTime lastFrame;
    private bool pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        lastFrame = DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

        if (pressed)
        {
            if ((DateTime.Now - lastFrame) > new TimeSpan(0, 0, 0, 0, 100))
            {
                boxesNumbers++;
                Instantiate(boxes);
                lastFrame = DateTime.Now;
            }
        }

    }
}
