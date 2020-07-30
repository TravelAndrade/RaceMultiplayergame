using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashMoney : MonoBehaviour {

    public int CashValue;
    public static int TotalCash;
    public GameObject CashDisplay;

    void Start()
    {
        TotalCash = PlayerPrefs.GetInt("SavedMoney");
    }

    void Update()
    {
        CashValue = TotalCash;
        CashDisplay.GetComponent<Text>().text = "Cash £" + CashValue;
    }
}
