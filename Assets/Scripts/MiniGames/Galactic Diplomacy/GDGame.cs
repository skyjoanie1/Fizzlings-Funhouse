using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDGame : MonoBehaviour
{
    //Strings to hold the values of the answer and what the player has selected
    public string answer = "null";
    public string selected = "null";

    //Game Objects to hold and access the GDManager script and the start buttons
    public GameObject manager;
    public GameObject starts;

    //Game Objects for the scenario to play, and the options to select
    public GameObject scenarioTest;
    public GameObject sound1;
    public GameObject sound2;
    public GameObject sound3;

    //Variable to keep track of the current round
    public int round = 0;

    //Lists of the different scenerios and sound choices
    public List<Sprite> scenarioToShow;
    public List<AudioClip> soundsToPlay;

    //Chooses a random scenario from the list of scenarios for the player to interact with
    public int pick;

    //Selects a random case to generate the different options of sounds for the player to choose from
    public int pick2;

    private void Update()
    {
        //Check if the answer exists
        if (answer != "null")
        {
            //Check if the answer is correct
            if (IsRight())
            {
                //If the current round is less than the total number of rounds call the Start Round function
                if (round < manager.GetComponent<GDManager>().rounds)
                {
                    StartRound();
                }
                else
                {
                    //Otherwise reset the game
                    round = 0;
                    starts.SetActive(true);
                    this.gameObject.SetActive(false);
                }
            }
        }
    }

    public void StartRound()
    {
        //Reset the values of answer and selected to null for new round
        answer = "null";
        selected = "null";

        //Increase the value of the current round
        round++;

        //Set pick equal to a random number from the list of animals and set the animal sound to pick
        pick = Random.Range(0, scenarioToShow.Count);
        scenarioTest.GetComponent<SpriteRenderer>().sprite = scenarioToShow[pick];

        //Create cases for the three sound options for answers
        //Set pick2 equal to a random number to use a random case
        pick2 = Random.Range(1, 3);
        switch (pick2)
        {
            case 1:
                sound1.GetComponent<AudioSource>().clip = soundsToPlay[pick];
                sound2.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                sound3.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                break;
            case 2:
                sound2.GetComponent<AudioSource>().clip = soundsToPlay[pick];
                sound1.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                sound3.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                break;
            case 3:
                sound3.GetComponent<AudioSource>().clip = soundsToPlay[pick];
                sound1.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                sound2.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                break;
            default:
                sound2.GetComponent<AudioSource>().clip = soundsToPlay[pick];
                sound1.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                sound3.GetComponent<AudioSource>().clip = soundsToPlay[Random.Range(0, soundsToPlay.Count)];
                break;
        }
    }

    //Function to check if the player's answer is correct or not
    public bool IsRight()
    {
        if (answer == soundsToPlay[pick].name)
        {
            return true;
        }
        else
        {
            selected = "null";
            return false;
        }
    }
}
