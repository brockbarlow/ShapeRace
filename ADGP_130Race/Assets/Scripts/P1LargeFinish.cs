using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class P1LargeFinish : MonoBehaviour
{

    public bool finished = false;
    public GUIText timer;
    public float raceTime = 0.0f;
    //public bool racePaused = false;

    void OnTriggerEnter(Collider other)
    {
        //racePaused = true;

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
            if (GUI.Button(new Rect(10, 100, 300, 40), "Restart Game"))
            {
                SceneManager.LoadScene("P1 Large Track");
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

    void Update()
    {
        if (finished == false)
        {
            raceTime = raceTime + 1 * Time.deltaTime;
            timer.text = raceTime.ToString("f2");
        }
        //if (racePaused == true)
        //{
        //    Time.timeScale = 0.0f;
        //}
    }
}


//using UnityEngine;
//using System.Collections;
//using UnityEngine.SceneManagement;

//public class P1LargeFinish : MonoBehaviour
//{

//    public bool finished = false;
//    public GUIText timer;
//    public float raceTime = 0.0f;
//    public bool racePaused = false;

//    void OnTriggerEnter(Collider other)
//    {
//        racePaused = true;

//        if (other.CompareTag("Player"))
//        {
//            finished = true;
//        }
//    }

//    void OnGUI()
//    {
//        if (finished == true)
//        {
//            GUI.Button(new Rect(10, 50, 300, 40), "Finish!");
//            if (GUI.Button(new Rect(10, 100, 300, 40), "Restart Game"))
//            {
//                SceneManager.LoadScene("P1 Large Track");
//            }
//            if (GUI.Button(new Rect(10, 150, 300, 40), "Back to Title Screen"))
//            {
//                SceneManager.LoadScene("Title Menu");
//            }
//            if (GUI.Button(new Rect(10, 200, 300, 40), "Exit Game"))
//            {
//                Application.Quit();
//            }
//        }
//    }

//    void Update()
//    {
//        if (finished == false)
//        {
//            raceTime = raceTime + 1 * Time.deltaTime;
//            timer.text = raceTime.ToString("f2");
//        }
//        if (racePaused == true)
//        {
//            Time.timeScale = 0.0f;
//        }
//    }
//}

////    void OnGUI()
////    {
////        if (finished == true)
////        {
////            GUI.Button(new Rect(10, 50, 300, 40), "Finish!");
////            if (GUI.Button(new Rect(10, 100, 300, 40), "Restart Game"))
////            {
////                SceneManager.LoadScene("P1 Large Track");
////            }
////            if (GUI.Button(new Rect(10, 150, 300, 40), "Back to Title Screen"))
////            {
////                SceneManager.LoadScene("Title Menu");
////            }
////            if (GUI.Button(new Rect(10, 200, 300, 40), "Exit Game"))
////            {
////                Application.Quit();
////            }
////        }
////    }
////    float timescale;


////    void Update()
////    {
////        //timescale = Time.timeScale;

////        //    Time.timeScale = 0.0f;
////        if (!racePaused)
////            raceTime += Time.fixedDeltaTime;



////    }
////}
