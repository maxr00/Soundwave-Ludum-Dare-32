using UnityEngine;
using System.Collections;

public class LaneManager : MonoBehaviour {

	public bool check(string use){
		if (use == "a")
			return (Input.GetKey ("a") && !Input.GetKey ("s") && !Input.GetKey ("d") && !Input.GetKey ("f"));
		if (use == "s")
			return (!Input.GetKey ("a") && Input.GetKey ("s") && !Input.GetKey ("d") && !Input.GetKey ("f"));
		if (use == "d")
			return (!Input.GetKey ("a") && !Input.GetKey ("s") && Input.GetKey ("d") && !Input.GetKey ("f"));
		if (use == "f")
			return (!Input.GetKey ("a") && !Input.GetKey ("s") && !Input.GetKey ("d") && Input.GetKey ("f"));
		return false;
	}

	public bool checkDouble(string use1,string use2){
		bool a = Input.GetKey ("a"),s = Input.GetKey ("s"),d = Input.GetKey ("d"),f = Input.GetKey ("f");
		if (use1 == "a") {
			if(use2=="s")
				return a && s && !d && !f;
			if(use2=="d")
				return a && !s && d && !f;
			if(use2=="f")
				return a && !s && !d && f;
		}
		if (use1 == "s") {
			if(use2=="a")
				return a && s && !d && !f;
			if(use2=="d")
				return !a && s && d && !f;
			if(use2=="f")
				return !a && s && !d && f;
		}
		if (use1 == "d") {
			if(use2=="s")
				return !a && s && d && !f;
			if(use2=="a")
				return a && !s && d && !f;
			if(use2=="f")
				return !a && !s && d && f;
		}
		if (use1 == "f") {
			if(use2=="s")
				return !a && s && !d && f;
			if(use2=="d")
				return !a && !s && d && f;
			if(use2=="a")
				return a && !s && !d && f;
		}
		print ("BAD " +use1+"  " + use2);
		return false;
	}
}
