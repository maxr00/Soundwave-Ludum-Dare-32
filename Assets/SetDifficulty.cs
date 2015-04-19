using UnityEngine;
using System.Collections;

public class SetDifficulty : MonoBehaviour {

	public int level;
	public float speed;
	public string lvl;

	void OnMouseDown(){
		PlayerPrefs.SetFloat ("Speed" + level, speed);
		Application.LoadLevel (lvl);
	}

}
