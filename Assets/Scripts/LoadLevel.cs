using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public string Level;
	void OnMouseDown(){
		Application.LoadLevel (Level);
	}
}
