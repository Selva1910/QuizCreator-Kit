using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorExtension
{
    internal static void OpenWindow<T>() where T : SingletonEditorWindow
    {
        T window = EditorWindow.GetWindow<T>();
        window.titleContent = new GUIContent(window.WindowTitle);
        window.Show();
    }
    internal static void OpenWindow<T>(params Type[] desiredDockNextTo) where T : SingletonEditorWindow
    {
        T window = EditorWindow.GetWindow<T>(desiredDockNextTo);
        window.titleContent = new GUIContent(window.WindowTitle);
        window.Show();
    }
}
