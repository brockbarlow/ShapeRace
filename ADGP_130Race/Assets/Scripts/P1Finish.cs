using UnityEngine;
using System.Collections;

public class P1Finish : MonoBehaviour {

    public bool finished = false;
    public GUIText timer;
    public float raceTime = 0.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finished = true;
        }
    }

    void OnGUI()
    {
        if (finished == true)
        {
            GUI.Button(new Rect(10, 50, 300, 40), "Finish!");
            GUI.Button(new Rect(10, 100, 300, 40), "Please Press ESC");
        }
    }

    void Update()
    {
        if (finished == false)
        {
            raceTime = raceTime + 1 * Time.deltaTime;
            timer.text = raceTime.ToString("f2");
        }
    }
}
