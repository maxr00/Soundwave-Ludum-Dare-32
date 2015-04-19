using UnityEngine;
using System.Collections;

public class SongScript : MonoBehaviour {

	public int level;
	public GameObject note1Parent,note2Parent,note3Parent,note4Parent,note1,note2,note3,note4;
	public float songSpeed = 1;
	public string[] songSheet=new string[100];
	public float[] songTime = new float[100];
	public int current=-1;

	void Start () {
		songSpeed = PlayerPrefs.GetFloat ("Speed" + level);
		analyze (songTime[0], songSheet [0]);
	}

	void analyze(float time,string use){
		Invoke ("send" + use, time/songSpeed);
	}

	void after(GameObject n){
		n.gameObject.name = ""+(current-1);
		n.GetComponent<NoteScript> ().speed = songSpeed;
		if (current == songSheet.Length - 1)
			n.GetComponent<NoteScript> ().Final = true;

		if (songTime [current] == 0)
			n.GetComponent<NoteScript> ().doubleUse = songSheet[current-1];
		if (current<songTime.Length-1 && songTime [current+1] == 0)
			n.GetComponent<NoteScript> ().doubleUse = songSheet[current+1];
		
		current++;
		if (current < songSheet.Length)
			analyze (songTime [current], songSheet [current]);
	}

	void senda(){
		GameObject n = Instantiate (note1, note1Parent.transform.position, Quaternion.identity) as GameObject;
		n.transform.parent = note1Parent.transform;
		after (n);
	}

	void sends(){
		GameObject n = Instantiate (note2, note2Parent.transform.position, Quaternion.identity) as GameObject;
		n.transform.parent = note2Parent.transform;
		after (n);
	}

	void sendd(){
		GameObject n = Instantiate (note3, note3Parent.transform.position, Quaternion.identity) as GameObject;
		n.transform.parent = note3Parent.transform;
		after (n);
	}

	void sendf(){
		GameObject n = Instantiate (note4, note4Parent.transform.position, Quaternion.identity) as GameObject;
		n.transform.parent = note4Parent.transform;
		after (n);
	}
}
