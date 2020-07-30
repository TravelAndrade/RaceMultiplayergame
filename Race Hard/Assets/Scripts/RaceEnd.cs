using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceEnd : MonoBehaviour {

    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;

    void OnTriggerEnter()
    {
        if (TimeM.isTimeMode == true)
        {
            //Racetime mode

        }
        else
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            MyCar.SetActive(true);
            FinishCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            FinishMusic.Play();
            CashMoney.TotalCash += 100;
            PlayerPrefs.SetInt("SavedMoney", CashMoney.TotalCash);
        }
 
    }
    //finish script
}
