using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// By Naszir L. Merritt 
/// Start Buttton for rizzys mechanic shop
/// </summary>

public class RMSStartButton : MonoBehaviour
{
	//Start button object
	public Button startButton_Button, exitButton_Button;
	
	

	
	void Start()
	{

		//Listens and does start task on click
		startButton_Button.onClick.AddListener(StartTaskOnClick);

		//Listens and does exit task on click
		exitButton_Button.onClick.AddListener(ExitTaskOnClick);

	}

	//Function for what happens on click
	void StartTaskOnClick()
	{
		// Disables canvas
		RMSGameControl.titleScreen.SetActive(false);
		

		//Enable Tool Box panel
		RMSGameControl.toolBoxPanel.SetActive(true);

		//Enable Tool panel
		RMSGameControl.toolPanel.SetActive(true);
	}

	void ExitTaskOnClick()
	{


		//Enable Title screen
		RMSGameControl.titleScreen.SetActive(true);



		// Disable Tool box panel
		RMSGameControl.toolBoxPanel.SetActive(false);

		//disable Tool Panel
		RMSGameControl.toolPanel.SetActive(false);
	}


}
