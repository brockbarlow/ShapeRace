using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour {

    public void BackToMenu()
    {
        SceneManager.LoadScene("Mode Select");
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("Title Menu");
    }

    public void howToGame()
    {
        SceneManager.LoadScene("How To Menu");
    }

    public void modeGame()
    {
        SceneManager.LoadScene("Mode Select");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void toP1Large()
    {
        SceneManager.LoadScene("P1 Large Track");
    }

    public void toP1Medium()
    {
        SceneManager.LoadScene("P1 Medium Track");
    }

    public void toP1Menu()
    {
        SceneManager.LoadScene("P1 Menu");
    }

    public void toP1Small()
    {
        SceneManager.LoadScene("P1 Small Track");
    }

    public void toP2Large()
    {
        SceneManager.LoadScene("P2 Large Track");
    }

    public void toP2Medium()
    {
        SceneManager.LoadScene("P2 Medium Track");
    }

    public void toP2Menu()
    {
        SceneManager.LoadScene("P2 Menu");
    }

    public void toP2Small()
    {
        SceneManager.LoadScene("P2 Small Track");
    }
}
