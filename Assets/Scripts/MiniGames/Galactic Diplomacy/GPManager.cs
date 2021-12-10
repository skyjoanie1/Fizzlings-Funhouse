using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class GPManager : MonoBehaviour
{
    public Questions[] questions;
    private static List<Questions> unansweredQuestions;

    private Questions currentQuestion;

    public List<Sprite> questionImages;

    public int questionImagesIndex = 7;

    public int unansweredQuestionsIndex;

    int switchLoop;

    [SerializeField]
    private int scorePoints;
    [SerializeField]
    private Text scoreText;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            Debug.Log("RESTARTED");
            unansweredQuestions = questions.ToList<Questions>();
        }
        setCurrentQuestion();
        updateScore();
    }

    void questionsList()
    {
        switch (switchLoop)
        {
            case 7:
                questionImagesIndex = 7;
                unansweredQuestionsIndex = 7;
                break;
            case 6:
                questionImagesIndex = 6;
                unansweredQuestionsIndex = 6;
                break;
            case 5:
                questionImagesIndex = 5;
                unansweredQuestionsIndex = 5;
                break;
            case 4:
                questionImagesIndex = 4;
                unansweredQuestionsIndex = 4;
                break;
            case 3:
                questionImagesIndex = 3;
                unansweredQuestionsIndex = 3;
                break;
            case 2:
                questionImagesIndex = 2;
                unansweredQuestionsIndex = 2;
                break;
            case 1:
                questionImagesIndex = 1;
                unansweredQuestionsIndex = 1;
                break;

                
        }
    }

    void updateScore()
    {
        scoreText.text = "Score: " + scorePoints;
    }
    public void AddScore(int newScore)
    {
        scorePoints += newScore;
        updateScore();
    }

    void setCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];


    }

    void Transition()
    {

        unansweredQuestions.Remove(currentQuestion);
        //Application.LoadLevel ("Game");
        Start();
    }

    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            Debug.Log("correct");
            AddScore(1);
        }
        else
            Debug.Log("incorrect");

        Transition();
    }
    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            Debug.Log("correct");
            AddScore(1);
        }
        else
            Debug.Log("incorrect");

        Transition();
    }

}