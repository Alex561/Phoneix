using UnityEngine;
using System.Collections;

public class FistScript : MonoBehaviour {
	public hp hp1;
	public p2Controller p2;
	// Use this for initialization
	void Start () {
		hp1 = GameObject.Find ("HP1").GetComponent<hp> ();
		p2 = GameObject.Find ("Steve Salute(For Blender Only)").GetComponent<p2Controller> ();
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "SHead") {
			Debug.Log("HIT!!!!!!!!");
			p2.ow();
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
