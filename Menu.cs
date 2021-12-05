using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGameFacil()
    {
        SceneManager.LoadScene("LevelFacil");
    }
    public void PlayGameNormal()
    {
        SceneManager.LoadScene("LevelNormal");
    }
    public void PlayGameDificil()
    {
        SceneManager.LoadScene("LevelDificil");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Saliendo");
        Application.Quit();
    }
}
