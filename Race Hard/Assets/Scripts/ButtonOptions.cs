﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {
    /*
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    */


    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene(5);
    }

    //Track selection buttons

    public void Track01()
    {
        SceneManager.LoadScene(2);
    }

    public void Track02()
    {
        SceneManager.LoadScene(3);
    }

    public void Credits()
    {
        SceneManager.LoadScene(4);
    }

}

