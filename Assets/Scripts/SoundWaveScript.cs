using UnityEngine;
using System.Collections;

public class SoundWaveScript : MonoBehaviour {
	public float speed,life;
	void Start(){
		Destroy (gameObject, life/2);
	}

	void FixedUpdate () {
		transform.Translate (speed, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D c) {
		if (c.tag == "Player") {
			print ("Ow");
		}
		//if(c.transform!=transform.parent)
			//Destroy (gameObject);
	}
}
