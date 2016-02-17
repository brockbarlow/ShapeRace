using UnityEngine;
using System.Collections;

public class TeacherTest : MonoBehaviour
{
    public float timeLyfe;
    void Update()
    {
        Time.timeScale = 0.0f;
        timeLyfe = Time.timeScale;
    }

}
