using UnityEngine;
using System.Collections;

public class AIControl : MonoBehaviour {

	public float songSpeed;
	public string[] songSheet;
	public float[] songTime;
	public int current=0;
	public GameObject soundWave;

	//public AudioClip a,s,d,f;

	void Start () {
		songSheet = GameObject.FindGameObjectWithTag ("Guitar").GetComponent<SongScript> ().songSheet;
		songTime = GameObject.FindGameObjectWithTag ("Guitar").GetComponent<SongScript> ().songTime;
		songSpeed = PlayerPrefs.GetFloat ("Speed" + GameObject.FindGameObjectWithTag ("Guitar").GetComponent<SongScript> ().level);
		analyze (songTime[0]+3.75f, songSheet [0]);
	}
	
	void analyze(float time,string use){
		Invoke ("after", (time)/songSpeed);
	}
	
	void after(){
		GameObject n = Instantiate (soundWave, transform.position, Quaternion.identity) as GameObject;
		n.gameObject.name = "" + (current - 1);
		//n.transform.parent = GameObject.FindGameObjectWithTag ("Enemy").transform;
		n.GetComponent<SoundWaveScript> ().speed = -n.GetComponent<SoundWaveScript> ().speed;
		if (songTime [current+1] == 0){
			GetComponent<Animator>().Play("Strum2");
			n = Instantiate (soundWave, new Vector2 (transform.position.x - 3, transform.position.y), Quaternion.identity) as GameObject;
			//n.transform.parent = GameObject.FindGameObjectWithTag ("Enemy").transform;
			n.GetComponent<SoundWaveScript> ().speed = -n.GetComponent<SoundWaveScript> ().speed;
		}else
			GetComponent<Animator>().Play("Strum1");

		//sound (songSheet[current]);

		current++;
		if (current < songSheet.Length)
			analyze (songTime [current], songSheet [current]);
	}

/*	void sound(string use){
		if (use == "a")
			GetComponent<AudioSource> ().clip = a;
		if (use == "s")
			GetComponent<AudioSource> ().clip = s;
		if (use == "d")
			GetComponent<AudioSource> ().clip = d;
		if (use == "f")
			GetComponent<AudioSource> ().clip = f;
		GetComponent<AudioSource> ().Play ();
	}*/
}
