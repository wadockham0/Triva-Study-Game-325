using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using DG.Tweening;
using System.Net;
using UnityEngine.UI;
using UnityEngine.UIElements;

[System.Serializable]

public class AnswersUI : MonoBehaviour
{


    public int AnswerIndex;

    public UnityEngine.UI.Image CorrectImage;

    public UnityEngine.UI.Image IncorectImage;

    public void OnAnswerClicked()
    {
        bool results = QuestionsManager.Instance.AnswerQuestion(AnswerIndex);


        if (results)
        {
            CorrectImage.gameObject.SetActive(true);
            Debug.Log(results);
        }
        else
        {
            IncorectImage.gameObject.SetActive(true);
            Debug.Log(results);
        }
    }
}


