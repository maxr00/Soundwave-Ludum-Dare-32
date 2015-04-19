using UnityEngine;
using System.Collections;

public class LoadBattle : MonoBehaviour {

	public string lvl;

	void OnMouseDown(){
		if(!GetComponent<TextMesh>().text.Contains("???"))
			Application.LoadLevel (lvl);
	}
}
