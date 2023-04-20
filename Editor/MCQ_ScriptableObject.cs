using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "MCQ_Set.asset",menuName = "QuizCreator/MultiChoice Q&&A")]
public class MCQ_ScriptableObject : ScriptableObject
{
    public List<MCQuestions> questions = new List<MCQuestions>();
}
