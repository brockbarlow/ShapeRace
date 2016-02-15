using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class modeGame : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("Mode Select");
    }
}
