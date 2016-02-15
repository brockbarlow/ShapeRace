using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToTitle : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("Title Menu");
    }
}
