using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class P2MediumFinish : MonoBehaviour
{

    public bool finished = false;
    public bool finished2 = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finished = true;
        }
        if (other.CompareTag("Player2"))
        {
            finished2 = true;
        }
    }

    void OnGUI()
    {
        if (finished == true)
        {
            GUI.Button(new Rect(10, 50, 300, 40), "P1 is the Winner!");
            if (GUI.Button(new Rect(10, 100, 300, 40), "Restart Game"))
            {
                SceneManager.LoadScene("P2 Medium Track");
            }
            if (GUI.Button(new Rect(10, 150, 300, 40), "Back to Title Screen"))
            {
                SceneManager.LoadScene("Title Menu");
            }
            if (GUI.Button(new Rect(10, 200, 300, 40), "Exit Game"))
            {
                Application.Quit();
            }
        }
        if (finished2 == true)
        {
            GUI.Button(new Rect(10, 50, 300, 40), "P2 is the Winner!");
            if (GUI.Button(new Rect(10, 100, 300, 40), "Restart Game"))
            {
                SceneManager.LoadScene("P2 Medium Track");
            }
            if (GUI.Button(new Rect(10, 150, 300, 40), "Back to Title Screen"))
            {
                SceneManager.LoadScene("Title Menu");
            }
            if (GUI.Button(new Rect(10, 200, 300, 40), "Exit Game"))
            {
                Application.Quit();
            }
        }
    }
}
