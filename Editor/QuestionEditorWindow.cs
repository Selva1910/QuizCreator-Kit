using UnityEditor;
using UnityEngine;

public class QuestionEditorWindow : SingletonEditorWindow
{
    public override string WindowTitle => "Questions Editor";
    public override Vector2 MinSize => new Vector2(700, 500);

    private SerializedObject serializedObject;
    private SerializedProperty questionTextProperty;

    private Vector2 scrollPosition = Vector2.zero;
    public override void OnDraw()
    {
        using (var scrollView = new EditorGUILayout.ScrollViewScope(scrollPosition))
        {
            scrollPosition = scrollView.scrollPosition;
            serializedObject.Update();
            EditorGUILayout.PropertyField(questionTextProperty, new GUIContent("All Questions"));
            serializedObject.ApplyModifiedProperties();
        }

        if(GUILayout.Button(new GUIContent("Export","Export the current Question List as a CSV.")))
        {

        }
        if (GUILayout.Button(new GUIContent("Import","Import a Question Data from Excel")))
        {

        }

    }

    private void OnEnable()
    {

        var question = ScriptableObject.CreateInstance<MCQ_ScriptableObject>();
        serializedObject = new SerializedObject(question);
        questionTextProperty = serializedObject.FindProperty("questions");

    }




}