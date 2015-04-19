using UnityEngine;
using System.Collections;

public class LaneScript : MonoBehaviour {

	public string use;
	public Color used;
	Color def;

	void Start(){
		def = GetComponent<SpriteRenderer> ().color;
	}

	void Update () {
		if (Input.GetKey (use)) {
			GetComponent<SpriteRenderer>().color=used;
		}else 
			GetComponent<SpriteRenderer>().color=def;
	}
}
