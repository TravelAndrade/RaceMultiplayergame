using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsFinished : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(FinishCredits());
	}

    IEnumerator FinishCredits()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(0);
    }
}
