using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Image Guidbackground;
    public Button Quit;

    private void Start()
    {
        Guidbackground.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void Guid()
    {
        Guidbackground.gameObject.SetActive(true);
        Quit.gameObject.SetActive(true);
    }

    public void QuitGuid()
    {
        Guidbackground.gameObject.SetActive(false);
        Quit.gameObject.SetActive(false);
    }
}
