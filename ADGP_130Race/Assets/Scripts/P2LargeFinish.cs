using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class P2LargeFinish : MonoBehaviour
{

    public bool finished = false;

    void OnTriggerEnter()
    {
        finished = true;
    }

    void OnGUI()
    {
        if (finished == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 100, 20), "Winner!");
            if (GUI.Button(new Rect(10, 50, 300, 40), "Restart Game"))
            {
                SceneManager.LoadScene("P2 Large Track");
            }
            if (GUI.Button(new Rect(10, 100, 300, 40), "Back to Title Screen"))
            {
                SceneManager.LoadScene("Title Menu");
            }
            if (GUI.Button(new Rect(10, 150, 300, 40), "Exit Game"))
            {
                Application.Quit();
            }
        }
    }
}
