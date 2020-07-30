using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookStableabiliy : MonoBehaviour {

    public GameObject Car;
    public float CarplayerX;
    public float CarplayerY;
    public float CarplayerZ;

	
	// Update is called once per frame
	void Update () {
        CarplayerX = Car.transform.eulerAngles.x;
        CarplayerY = Car.transform.eulerAngles.y;
        CarplayerZ = Car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarplayerX - CarplayerX, CarplayerY, CarplayerZ - CarplayerZ);

    }
}
