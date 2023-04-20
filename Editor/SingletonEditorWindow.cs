using UnityEngine;
using UnityEditor;

public abstract class SingletonEditorWindow : EditorWindow
{
    public abstract string WindowTitle { get; }
    public abstract Vector2 MinSize { get; }
    public abstract void OnDraw();

    private void OnGUI()
    {
        OnDraw();
    }

    public SingletonEditorWindow()
    {
        minSize = new Vector2(MinSize.x, MinSize.y);
    }
}