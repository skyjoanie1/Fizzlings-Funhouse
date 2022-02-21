using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// By Naszir L. Merritt 
/// Game controller for rizzys mechanic shop
/// </summary>

public class RMSGameControl : MonoBehaviour
{
	// Store bought tools objects
	public Button wrenchButton, screwdriverButton, oilButton;
	public GameObject wrenchSoldText, screwdriverSoldText, oilSoldText;
	public Text wrenchPriceText, screwdriverPriceText, oilPriceText;

	//Game panel objects
	public GameObject wrench, screwdriver, oil;
	public Text cashText;
	public int currentCash;

	// price and bools
	private bool isWrenchSold, isScrewdriverSold, isOilSold;
	public int wrenchPrice = 10, screwdriverPrice = 20, oilPrice = 30;


	

	//panel objects
	public static GameObject toolBoxPanel, toolPanel;

	// end game objects
	public static GameObject endGame;
	public Text endScore;
	public static GameObject titleScreen;
	

	// Start is called before the first frame update
	void Start()
	{



		// sets value of the toolBoxPanel to the ToolBox Panel in scene
		toolBoxPanel = GameObject.Find("ToolBox Panel");
		// sets value of the toolBoxPanel to the ToolBox Panel in scene
		toolPanel = GameObject.Find("Tools Panel");

		endGame = GameObject.Find("End Game");

		titleScreen = GameObject.Find("Title");




		//on game start toobox panel will disable 
		toolBoxPanel.SetActive(false);

		//on game start tool panel will disable
		toolPanel.SetActive(false);

		endGame.SetActive(false);


	
		





		// Disable Bought tools
		wrench.SetActive(false);
		screwdriver.SetActive(false);
		oil.SetActive(false);

		//disable store buttons
		wrenchButton.interactable = false;
		oilButton.interactable = false;
		screwdriverButton.interactable = false;

		// disable soldtexts for store tools
		wrenchSoldText.SetActive(false);
		screwdriverSoldText.SetActive(false);
		oilSoldText.SetActive(false);

		// set prices of tools
		oilPriceText.text = oilPrice.ToString() + "  Dollars";
		wrenchPriceText.text = wrenchPrice.ToString() + "  Dollars";
		screwdriverPriceText.text = screwdriverPrice.ToString() + "  Dollars";


		

		






	}

	void Update()
	{
		// display cash gained
		cashText.text = currentCash + " Dollars";

		//Check if you can buy new tool
		//also check if game needs to be reset
		

		if (GameObject.Find("ToolBox Panel") == false)
		{
			ResetGame();


		}
		else
			CanYouPurchase();

		// turn on end game screen when requirements are met
		if (currentCash >= 100 && isWrenchSold == true && isOilSold == true && isScrewdriverSold == true)
		{

			EndGame();

		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}


	public void IncreaseCash()
	{

		// sets cash increment to +1
		if (isWrenchSold == false && isOilSold == false && isScrewdriverSold == false)
		{
			currentCash += 1;
		}
		
		//sets cash increment to +2
		if (isWrenchSold == true || isOilSold == true || isScrewdriverSold == true)
		{
			currentCash += 2;
		}

	
		// sets cash increment to +10
		if (isOilSold == true && isScrewdriverSold == true && isWrenchSold == true)
		{
			currentCash += 10;
		}
		
			

		
	}

	public void SellOil()
	{
		// give player oil
		oil.SetActive(true);
		//subtract cash 
		currentCash -= oilPrice;
		// set oil sold
		isOilSold = true;
		// display oil sold
		oilSoldText.SetActive(true);
		// disbale original price 
		oilPriceText.gameObject.SetActive(false);


	}

	public void SellScrewdriver()
	{
		// give player screwdriver 
		screwdriver.SetActive(true);
		// decrease current cash with purchase
		currentCash -= screwdriverPrice;
		// set screwdriver as sold
		isScrewdriverSold = true;
		// display screwdriver is sold text
		screwdriverSoldText.SetActive(true);
		// disable original price
		screwdriverPriceText.gameObject.SetActive(false);

	}

	public void SellWrench()
	{
		// give player wrench
		wrench.SetActive(true);
		//decrease current cash 
		currentCash -= wrenchPrice;
		// set wrench sold
		isWrenchSold = true;
		//display wrench sold text 
		wrenchSoldText.SetActive(true);
		// disable origninal price
		wrenchPriceText.gameObject.SetActive(false);
	}

	public void CanYouPurchase()
	{
		// check cash to disable interactables 
		if (currentCash < oilPrice)
			oilButton.interactable = false;

		if (currentCash < screwdriverPrice)
			screwdriverButton.interactable = false;

		if (currentCash < wrenchPrice)
			wrenchButton.interactable = false;

		// check if you have enough cash and tool is not sold
		// so you buy it 

		if (!isWrenchSold && currentCash >= wrenchPrice)
		{
			wrenchButton.interactable = true;

		}

		if (!isScrewdriverSold && currentCash >= screwdriverPrice)
		{
			screwdriverButton.interactable = true;
		}

		if (!isOilSold && currentCash >= oilPrice)
		{
			oilButton.interactable = true;
		}




	}

	void ResetGame()
	{
		// set is sold to false
		isScrewdriverSold = false;
		isOilSold = false;
		isWrenchSold = false;


		// reset cash
		currentCash = 0;

		// Disable Bought tools
		wrench.SetActive(false);
		screwdriver.SetActive(false);
		oil.SetActive(false);

		

		// disable soldtexts for store tools
		wrenchSoldText.SetActive(false);
		screwdriverSoldText.SetActive(false);
		oilSoldText.SetActive(false);

		// set prices of tools
		oilPriceText.text = oilPrice.ToString() + "  Dollars";
		wrenchPriceText.text = wrenchPrice.ToString() + "  Dollars";
		screwdriverPriceText.text = screwdriverPrice.ToString() + "  Dollars";

		// reset price text to be active
		wrenchPriceText.gameObject.SetActive(true);
		screwdriverPriceText.gameObject.SetActive(true);
		oilPriceText.gameObject.SetActive(true);


		
	}

	void EndGame()
	{
		//on game start toobox panel will disable 
		toolBoxPanel.SetActive(false);

		//on game start tool panel will disable
		toolPanel.SetActive(false);

		// display End Game canvas
		endGame.SetActive(true);

		// set score for end game screen
		endScore.text = "Final Score: " + currentCash + " Dollars";




	}

	public void TitleScreen()
	{
		// display End Game canvas
		endGame.SetActive(false);

		//Enable Title screen
		titleScreen.SetActive(true);


	}
}
