using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//car selection

public class Globalcar : MonoBehaviour {

    public static int CarType; //1=Red, 2=Blue 3=Green

    public GameObject TrackWindow;

    public void RedCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void BlueCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }

    public void GreenCar()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }

}

