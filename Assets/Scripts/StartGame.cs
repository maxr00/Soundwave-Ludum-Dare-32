using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	void Update () {
		if (Input.anyKeyDown && !Input.GetMouseButtonDown(0)) {
			Application.LoadLevel("Menu2");
		}
	}
	void OnMouseDown(){
		Application.LoadLevel("Menu2");
	}
}
