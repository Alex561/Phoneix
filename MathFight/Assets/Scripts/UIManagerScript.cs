﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManagerScript : MonoBehaviour {
	public Canvas QuitMenu;
	public Button startText;
	public Button quitText;
	public Button RulesText;

	void Start(){
		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		quitText = quitText.GetComponent<Button> ();
		RulesText = RulesText.GetComponent<Button> ();
		QuitMenu.enabled = false;

	}

	public void QuitPress(){
		QuitMenu.enabled = true;
		startText.enabled = false;
		quitText.enabled = false;
		RulesText.enabled = false;
	}

	public void NoPress(){
		QuitMenu.enabled = false;
		startText.enabled = true;
		quitText.enabled = true;
		RulesText.enabled = true;
	}

	public void StartGame(){
		Application.LoadLevel ("trainingscene");
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
