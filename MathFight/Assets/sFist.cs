using UnityEngine;
using System.Collections;

public class sFist : MonoBehaviour {
	public hp hp2;
	public p1Controller p1;
	// Use this for initialization
	void Start () {
		hp2 = GameObject.Find ("HP1").GetComponent<hp> ();
		p1 = GameObject.Find ("batman hero184").GetComponent<p1Controller> ();
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Knee") {
			Debug.Log("HIT!!!!!!!!");
			p1.ow();
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
