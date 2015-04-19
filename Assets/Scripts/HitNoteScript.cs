using UnityEngine;
using System.Collections;

public class HitNoteScript : MonoBehaviour {

	public int level;
	public GameObject soundWave;
	GameObject player;
	public Color col1,col2,col3,col4;
	public Color col;
	public GameObject FinalBlast,win;
	public AudioSource a,s,d,f;

	void Start(){ player=GameObject.FindGameObjectWithTag("Player");}

	public void NoteSuccess(){
		GetComponent<AudioSource>().Play();
		player.GetComponent<Animator> ().Play ("Strum1");
		GameObject s=Instantiate (soundWave, player.transform.position, Quaternion.identity) as GameObject;
		s.transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;
		s.GetComponent<SpriteRenderer> ().color = col;
	}

	public void DoubleNoteSuccess(string use1){
		GetComponent<AudioSource>().Play();
		player.GetComponent<Animator> ().Play ("Strum2");
		GameObject s=Instantiate (soundWave, player.transform.position, Quaternion.identity) as GameObject;
		//s.transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;
		s.GetComponent<SpriteRenderer> ().color = col;
		s=Instantiate (soundWave, new Vector2(player.transform.position.x+3,player.transform.position.y), Quaternion.identity) as GameObject;
		//s.transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;
		if(use1=="a")
			s.GetComponent<SpriteRenderer> ().color = col1;
		if(use1=="s")
			s.GetComponent<SpriteRenderer> ().color = col2;
		if(use1=="d")
			s.GetComponent<SpriteRenderer> ().color = col3;
		if(use1=="f")
			s.GetComponent<SpriteRenderer> ().color = col4;
	}

	public void FinalNote(){
		a.Play (); s.Play (); d.Play (); f.Play ();
		Instantiate(FinalBlast,GameObject.FindGameObjectWithTag("Player").transform.position,Quaternion.identity);
		GameObject.FindGameObjectWithTag ("Enemy").GetComponent<Animator> ().Play ("FlipOut");
		win.SetActive (true);
		//Time.timeScale = 0;
		Invoke ("won", 4f);
	}

	void won(){
		if (PlayerPrefs.GetInt ("Completed") <= level) {
			PlayerPrefs.SetInt ("Completed", level);
			GameObject.FindGameObjectWithTag("Health").GetComponent<Health>().checkPerfect(level);
		}
		Application.LoadLevel ("Menu2");
	}
}
