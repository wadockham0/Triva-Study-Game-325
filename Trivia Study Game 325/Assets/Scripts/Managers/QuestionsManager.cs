using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class QuestionsManager : Singleton<QuestionsManager>
{
    public QuestionUI Question;

    public Transform CorrectImage; 

    public Transform IncorectImage;

   

    public string CategoryName;

    private GameManager _gameManager;

    private QuestionModel _currentquestion;

    private void Start ()
    {
        _gameManager = GameManager.Instance;

        LoadNextQuestion();
    }

    void LoadNextQuestion()
    {
        _currentquestion = _gameManager.GetQuestionForCategory(CategoryName); 
        if (_currentquestion != null)
        {
            Question.PopulateQuestion(_currentquestion);
        }
    } 

    public bool AnswerQuestion(int answerindex)
    {
        return _currentquestion.CorrectanswerIndex == answerindex;
    }
}
