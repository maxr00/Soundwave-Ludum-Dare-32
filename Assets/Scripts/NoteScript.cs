using UnityEngine;
using System.Collections;

public class NoteScript : MonoBehaviour {

	public float speed=1f;
	public string use,doubleUse="";
	public GameObject player;
	public bool Final;

	void FixedUpdate(){
		transform.Translate (0, -speed, 0);
	}

	void Update(){
		if (transform.position.y <= -70 && transform.position.y>-90) {
			GetComponent<SpriteRenderer>().color=Color.white;
			if (Input.GetMouseButtonDown(0) && Input.GetKey(use)) {
				if(doubleUse=="" && transform.parent.parent.parent.GetComponent<LaneManager>().check(use)){
					if(!Final)transform.parent.GetComponent<HitNoteScript>().NoteSuccess();
					else transform.parent.GetComponent<HitNoteScript>().FinalNote();
					Destroy(gameObject);
				}else if(doubleUse!="" && transform.parent.parent.parent.GetComponent<LaneManager>().checkDouble(use,doubleUse)){
					if(!Final)Destroy(gameObject);
					else transform.parent.GetComponent<HitNoteScript>().FinalNote();
					transform.parent.GetComponent<HitNoteScript>().DoubleNoteSuccess(doubleUse);
				}
			}
		}
		if (transform.position.y <= -90) {
			GetComponent<SpriteRenderer>().color=Color.gray;
		}
		if (transform.position.y <= -110) {
			if(Final)transform.parent.GetComponent<HitNoteScript>().FinalNote();
			if(doubleUse!="")
				GameObject.FindGameObjectWithTag("Health").GetComponent<Health>().doubleHit();
			else
				GameObject.FindGameObjectWithTag("Health").GetComponent<Health>().hit();
			Destroy(gameObject);
		}
	}

}
