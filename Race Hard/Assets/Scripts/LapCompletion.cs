using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompletion : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDSP;
    public GameObject SecondDSP;
    public GameObject MilliDSP;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;
    public float RawTime;
    public GameObject RaceFinish;

    void Update()
    {
        if (LapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter()
    {
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LaptimeM.RawTime <= RawTime)
        {
            if (LaptimeM.SecondCounter <= 9)
            {
                SecondDSP.GetComponent<Text>().text = "0" + LaptimeM.SecondCounter + ".";
            }
            else
            {
                SecondDSP.GetComponent<Text>().text = "" + LaptimeM.SecondCounter + ".";
            }

            if (LaptimeM.MinuteCounter <= 9)
            {
                MinuteDSP.GetComponent<Text>().text = "0" + LaptimeM.MinuteCounter + ".";
            }
            else
            {
                MinuteDSP.GetComponent<Text>().text = "" + LaptimeM.MinuteCounter + ".";
            }

            MilliDSP.GetComponent<Text>().text = "" + LaptimeM.MilliCounter;
        }

        PlayerPrefs.SetInt("MinSave", LaptimeM.MinuteCounter);
        PlayerPrefs.SetInt("SecSave", LaptimeM.SecondCounter);
        PlayerPrefs.SetFloat("MilliSave", LaptimeM.MilliCounter);
        PlayerPrefs.SetFloat("RawTime", LaptimeM.RawTime);

        LaptimeM.MinuteCounter = 0;
        LaptimeM.SecondCounter = 0;
        LaptimeM.MilliCounter = 0;
        LaptimeM.RawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        
    }

}
