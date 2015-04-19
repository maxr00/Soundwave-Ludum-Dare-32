using UnityEngine;
using System.Collections;

public class ResetGame : MonoBehaviour {
	void OnMouseDown(){
		PlayerPrefs.DeleteAll ();
		Application.LoadLevel (Application.loadedLevel);
	}
}
