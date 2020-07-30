﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Posdown : MonoBehaviour {

    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPos")
        {
            positionDisplay.GetComponent<Text>().text = "2nd Place";
        }
    }

}