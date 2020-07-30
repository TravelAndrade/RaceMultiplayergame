
var CarController: GameObject;
var OPScar: GameObject;

function Start () {
	CarController.GetComponent("CarUserControl").enabled = true;
    OPScar.GetComponent("CarAIControl").enabled = true;
}