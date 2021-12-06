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

        questionImage = currentQuestion.questions;

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