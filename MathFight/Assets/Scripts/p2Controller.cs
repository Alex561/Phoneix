using UnityEngine;
using System.Collections;

public class p2Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp1;
	public hp hp2;
	public AudioClip correctSound1;
	public AudioClip wrongSound1;
	public AudioClip punch;
	private AudioSource source;
	Animator anim_s;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		anim_s= GetComponent<Animator> ();
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp1 = GameObject.Find ("HP1").GetComponent<hp> ();
		hp2 = GameObject.Find ("HP2").GetComponent<hp> ();
	}
	
	// Update is called once per frame
	public void ow (){
		anim_s.SetTrigger("Punched");
		Debug.Log ("I got Punched");
		hp2.health -= 1;


	}
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.O) && pg.ap2 !=0)
		{
			
			pg.ap2 -=1;
			Debug.Log("o");
			//hp1.health-=1;
			anim_s.SetTrigger("Punch");
			source.PlayOneShot(punch,5f);
		}
		else if (Input.GetKeyDown (KeyCode.L)) {
			anim_s.SetTrigger("Block");
		}
		if (Input.GetKeyDown(KeyCode.B)){
			if(pg.question== ("0U") || pg.question == ("3U")){
				pg.ap2+=1;
				source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.N)){
			if(pg.question== ("1U") ){
				pg.ap2+=1;
			source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.M)){
			if(pg.question== ("4U")){
				pg.ap2+=1;
				source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.Comma)){
			if(pg.question== ("2U") ){
				pg.ap2+=1;
				source.PlayOneShot(correctSound1,.5f);}
			else{
				pg.ap2-=1;
				source.PlayOneShot(wrongSound1,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (hp1.health == 0)
			Application.LoadLevel ("SteveWins");

	}
}
