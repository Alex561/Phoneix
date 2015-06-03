using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManagerScript : MonoBehaviour {
	public Canvas QuitMenu;
	public Canvas RulesMenu;
	public Button startText;
	public Button quitText;
	public Button RulesText;

	void Start(){
		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		RulesMenu = RulesMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		quitText = quitText.GetComponent<Button> ();
		RulesText = RulesText.GetComponent<Button> ();
		QuitMenu.enabled = false;
		RulesMenu.enabled = false;

	}

	public void QuitPress(){
		QuitMenu.enabled = true;
		startText.enabled = false;
		quitText.enabled = false;
		RulesText.enabled = false;
	}
	public void RulesPress(){
		RulesMenu.enabled = true;
		startText.enabled = false;
		quitText.enabled = false;
		RulesText.enabled = false;
	}
	public void NoPress(){
		QuitMenu.enabled = false;
		RulesMenu.enabled = false;
		startText.enabled = true;
		quitText.enabled = true;
		RulesText.enabled = true;
	}
	public void menuPress(){
		Application.LoadLevel ("menu_scene");
	}
	public void ok()
	{
		QuitMenu.enabled = false;
		RulesMenu.enabled = false;
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
