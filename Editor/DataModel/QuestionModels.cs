using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class MCQuestions
{
    public string context;
    public List<Choice> options;
}

[System.Serializable]
public class Choice
{
    public string choice;
    public bool isAnswer;

    public Choice(string choice, bool isAnswer)
    {
        this.choice = choice;
        this.isAnswer = isAnswer;
    }
}

public class EdUtils
{
    static Dictionary<EditorWindow, GUIContent> _winTitleContentByEditor;
    public static void SetWindowTitle(EditorWindow editor, Texture icon, string title)
    {
        GUIContent titleContent;
        if (_winTitleContentByEditor == null) _winTitleContentByEditor = new Dictionary<EditorWindow, GUIContent>();
        if (_winTitleContentByEditor.ContainsKey(editor))
        {
            titleContent = _winTitleContentByEditor[editor];
            if (titleContent != null)
            {
                if (titleContent.image != icon) titleContent.image = icon;
                if (title != null && titleContent.text != title) titleContent.text = title;
                return;
            }
            _winTitleContentByEditor.Remove(editor);
        }
        titleContent = GetWinTitleContent(editor);
        if (titleContent != null)
        {
            if (titleContent.image != icon) titleContent.image = icon;
            if (title != null && titleContent.text != title) titleContent.text = title;
            _winTitleContentByEditor.Add(editor, titleContent);
        }
    }

    static GUIContent GetWinTitleContent(EditorWindow editor)
    {
        const BindingFlags bFlags = BindingFlags.Instance | BindingFlags.NonPublic;
        PropertyInfo p = typeof(EditorWindow).GetProperty("cachedTitleContent", bFlags);
        if (p == null) return null;
        return p.GetValue(editor, null) as GUIContent;
    }

}