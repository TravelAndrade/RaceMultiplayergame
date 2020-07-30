using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour {

    public GameObject greenButton;
    public int cashValue;




    void Update()
    {
        cashValue = CashMoney.TotalCash;
        if (cashValue >= 100)
        {
            greenButton.GetComponent<Button>().interactable = true;
        }
    }

    public void GreenUnlock()
    {
        greenButton.SetActive(false);
        cashValue -= 100;
        CashMoney.TotalCash -= 100;
        PlayerPrefs.SetInt("SavedMoney", CashMoney.TotalCash);
        PlayerPrefs.SetInt("GreenBought", 100);
    }
}