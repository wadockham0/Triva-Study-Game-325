using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[System.Serializable]

public class GameManager : Singleton<GameManager>
{
    public GameModel Configuration;

    public QuestionModel GetQuestionForCategory(string categoryName)
    {
        CategoryModel categoryModel = Configuration.Categories.FirstOrDefault(category => category.CategoryName == categoryName); 

        if(categoryModel != null)
        {
            return categoryModel.Questions[0];
        } 

        return null;
    }
}
