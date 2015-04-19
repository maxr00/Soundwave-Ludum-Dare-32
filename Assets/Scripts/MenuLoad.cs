using UnityEngine;
using System.Collections;

public class MenuLoad : MonoBehaviour {
	
	public TextMesh b1,b2,b3;
	public GameObject jerry,renee;
	public SpriteRenderer soundwave;

	void Start () {
		if (PlayerPrefs.GetInt ("Completed") >= 1) {
			b2.text="Battle 2:\nJerry";
			jerry.GetComponent<SpriteRenderer>().color=Color.white;
			foreach(Transform t in jerry.transform){
				t.GetComponent<SpriteRenderer>().color=Color.white;
			}
		}
		if (PlayerPrefs.GetInt ("Completed") >= 2) {
			b3.text="Battle 3:\nRenee";
			renee.GetComponent<SpriteRenderer>().color=Color.white;
			foreach(Transform t in renee.transform){
				t.GetComponent<SpriteRenderer>().color=Color.white;
			}
		}

		if (PlayerPrefs.GetInt ("Perfected1")==1) b1.color = Color.yellow;
		if (PlayerPrefs.GetInt ("Perfected2")==1) b2.color = Color.yellow;
		if (PlayerPrefs.GetInt ("Perfected3")==1) b3.color = Color.yellow;
		if (PlayerPrefs.GetInt ("Perfected1") + PlayerPrefs.GetInt ("Perfected2") + PlayerPrefs.GetInt ("Perfected3") == 3)
			soundwave.color = Color.yellow;
	}
}
