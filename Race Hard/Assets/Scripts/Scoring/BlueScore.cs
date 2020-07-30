using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScore : MonoBehaviour {

    void OnTriggerEnter()
    {
        ScoreM.CurrentScore += 50;
        gameObject.SetActive(false);
    }
}
