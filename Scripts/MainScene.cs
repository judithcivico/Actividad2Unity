using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainScene : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void MoverCubo()
    {
        SceneManager.LoadScene("SceneCubo");
    }

    public void escenaImagen()
    {
        SceneManager.LoadScene("SceneImage");
    }

    public void escenaAudio()
    {
        SceneManager.LoadScene("SceneAudio");
    }

    public void escenaSumar()
    {
        SceneManager.LoadScene("SceneSuma");
    }
}
