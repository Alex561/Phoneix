using UnityEngine;
using System.Collections;

public class lessonremover : MonoBehaviour {
	//public string[] dialogue={"Math Lessons","This is a test"};
	//int index=0;
	//Rect dialoguerect=new Rect(435,100,500,50);
	public int ap1;
	public bool flip=false;
	public string name;
	public int input_count=0;
	private AudioSource source;
	public AudioClip correct;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		ap1 = 1;
	}
	void OnCollisionEnter (Collision col)
	{
		if(input_count==0)
		{
			GetComponent<TextMesh>().text = "what is the angle for tan 45?";
		}
		
		if(input_count==1)
		{
			
			GetComponent<TextMesh>().text = "what is the angle for cos 60?";
		}
		if(input_count==2)
		{
			GetComponent<TextMesh>().text = "what is the angle for sin 60?";
		}
		input_count++;

	}
	void Update () {
		if (input_count == 4) {
			Application.LoadLevel("Fight");
		}

			if (Input.GetKeyDown(KeyCode.V)&& input_count ==1) { 

				source.PlayOneShot(correct,5f);
				ap1+=1;

			}
			else if((Input.GetKeyDown(KeyCode.Z))&&(input_count==2))
			{
			source.PlayOneShot(correct,5f);
				ap1+=1;
			}
			else if(Input.GetKeyDown(KeyCode.X)&&input_count==3)
			{
			source.PlayOneShot(correct,5f);
				ap1+=1;
			}

	}
}