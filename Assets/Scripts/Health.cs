using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health,full;
	public GameObject lose,retry,exit;

	void Start(){
		Time.timeScale = 1f;
		health = GameObject.FindGameObjectWithTag ("Guitar").GetComponent<SongScript> ().songSheet.Length / 10;
		full = health;
	}

	public void hit(){
		health--;
		transform.localScale = new Vector2 (transform.localScale.x, 200*(health/full));
		if (health <= 0) {
			lose.SetActive(true);
			Time.timeScale = 0.5f;
			Invoke ("reload",0.6f);
		}
	}

	public void doubleHit(){
		health-=0.5f;
		transform.localScale = new Vector2 (transform.localScale.x, 200*(health/full));
		if (health <= 0) {
			lose.SetActive(true);
			Time.timeScale = 0.5f;
			Invoke ("reload",0.6f);
		}
	}

	void reload(){
		retry.SetActive (true);
		exit.SetActive (true);
		Time.timeScale = 0;
		//Application.LoadLevel(Application.loadedLevel);
	}

	public void checkPerfect(int level){
		if(health>=full)
			PlayerPrefs.SetInt ("Perfected1", level);
	}
}
