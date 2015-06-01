using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class batmananimation : MonoBehaviour {
	public lessonremover lr;
	public AudioClip punch;
	private AudioSource source;
	public Text answerC1;
	Animator anim;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();
		anim= GetComponent<Animator> ();
		lr = GameObject.Find("sandbag").GetComponent<lessonremover>();
		answerC1.text = "Z: 1/2 \n" +
			"X: sqrt(3)/2 \n" +
				"C:0 \n" +
				"V:1";
	}

	void Update ()
	{
		AnimatorStateInfo stateinfo = anim.GetCurrentAnimatorStateInfo (0);
		if (Input.GetKeyDown (KeyCode.W)&& lr.ap1!=0)
		{
			
			lr.ap1 -=1;
			Debug.Log("w");
			source.PlayOneShot(punch,5f);
			anim.SetTrigger("Punch");
			
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			anim.SetTrigger("Block");
		}
	
	}
}
