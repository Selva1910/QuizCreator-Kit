using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MenuManager
{
    [MenuItem("QuizCreator/New Quiz Wizard")]
    static void ShowNewWizard() => EditorExtension.OpenWindow<QuizWizard>();

    [MenuItem("QuizCreator/Edit Questions")]
    static void ShowQuizWindow() => EditorExtension.OpenWindow<QuestionEditorWindow>(typeof(QuizWizard));
}