using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour {

    // Use this for initialization
    public GameObject largeButton;
    public GameObject textClick;
    public GameObject menuButtons;

    public void StartMenu()
    {
        textClick.SetActive(false);
        menuButtons.SetActive(true);
        largeButton.SetActive(false);
    }

}
