using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour {

    public static int RaceMode; // 0=Race, 1=Score, 2=Time
    public GameObject Trackselect;

    public void PointMode()
    {
        RaceMode = 1;
        Trackselect.SetActive(true);
    }


    public void TimeMode()
    {
        RaceMode = 2;
        Trackselect.SetActive(true);
    }

    public void TheRaceMode()
    {
        RaceMode = 0;
        Trackselect.SetActive(true);
    }

}