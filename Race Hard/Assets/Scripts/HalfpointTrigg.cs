using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfpointTrigg : MonoBehaviour {

    public GameObject LapFullTrigg;
    public GameObject LapHalfTrigg;

    private void OnTriggerEnter(){
        LapFullTrigg.SetActive (true);
        LapHalfTrigg.SetActive (false);

    }




}
