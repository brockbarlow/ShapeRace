﻿using UnityEngine;
using System.Collections;

public class P2Finish : MonoBehaviour {

    public bool finished = false;
    public bool finished2 = false;
    public bool racePaused = false;

    void OnTriggerEnter(Collider other)
    {
        racePaused = true;

        if (other.CompareTag("Player"))
        {
            finished = true;
        }
        if (other.CompareTag("Player2"))
        {
            finished2 = true;
        }
    }

    void Update()
    {
        if (racePaused == true)
        {
            Time.timeScale = 0.0f;
        }
    }

    void OnGUI()
    {
        if (finished == true)
        {
            GUI.color = Color.red;
            GUI.Label(new Rect(140, 50, 300, 40), "P1 is the Winner!");
            GUI.Label(new Rect(135, 100, 300, 40), "Please Press ESC");
        }
        if (finished2 == true)
        {
            GUI.color = Color.blue;
            GUI.Label(new Rect(140, 50, 300, 40), "P2 is the Winner!");
            GUI.Label(new Rect(135, 100, 300, 40), "Please Press ESC");
        }
    }
}
