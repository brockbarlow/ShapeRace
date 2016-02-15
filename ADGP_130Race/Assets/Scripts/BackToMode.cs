using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMode : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("Mode Select");
    }
}
