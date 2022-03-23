using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect;
    public QuizManager quizManager;


    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer!");
            quizManager.StartCoroutine("CorrectAnswer");
        }
        else
        {
            Debug.Log("Incorrect Answer...");
            quizManager.StartCoroutine("IncorrectAnswer"); ;
        }
    }
}
