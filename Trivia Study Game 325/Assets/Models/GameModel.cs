using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

[CreateAssetMenu(menuName = "Trivia/Create Game Model")]

public class GameModel : ScriptableObject
{
  public List<CategoryModel> Categories;
}
