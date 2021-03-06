﻿using UnityEngine;
using System.Collections;

public class p1Controller : MonoBehaviour {

	public problemGenerator pg;
	public hp hp2;
	public hp hp1;
	public AudioClip correctSound;
	public AudioClip wrongSound;
	public AudioClip punch;
	private AudioSource source;
	Animator anim;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		anim= GetComponent<Animator> ();
		pg = GameObject.Find("problems").GetComponent<problemGenerator>();
		hp2 = GameObject.Find ("HP2").GetComponent<hp> ();
		hp1 = GameObject.Find ("HP1").GetComponent<hp> ();
	}
	public void ow (){
		anim.SetTrigger("Punched");
		hp1.health -= 1;
		Debug.Log ("I got Punched");
		
	}
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W)&& pg.ap1!=0)
		{
			
			pg.ap1 -=1;
			Debug.Log("w");
			source.PlayOneShot(punch,5f);
			//hp2.health -=1;
			anim.SetTrigger("Punch");
		
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			anim.SetTrigger("Block");
		}
		if (Input.GetKeyDown(KeyCode.Z)){
			if(pg.question== ("0U") || pg.question == ("3U")){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.C)){
			if(pg.question== ("4U") ){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.X)){
			if(pg.question== ("1U")){
				pg.ap1+=1;
			source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (Input.GetKeyDown(KeyCode.V)){
			if(pg.question== ("2U") ){
				pg.ap1+=1;
				source.PlayOneShot(correctSound,.5f);}
			else{
				pg.ap1-=1;
				source.PlayOneShot(wrongSound,.5f);}
			Debug.Log("Changing Problem");
			pg.question = pg.changeProblem();
			pg.flipTurn ();
		}
		if (hp2.health == 0)
			Application.LoadLevel ("BatmanWins");
		
	}
}
