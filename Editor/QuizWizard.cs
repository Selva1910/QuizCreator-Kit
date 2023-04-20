using UnityEngine;

public class QuizWizard : SingletonEditorWindow
{
    public override string WindowTitle => "Quiz Wizard";
    public override Vector2 MinSize => new Vector2(600,400);

    public override void OnDraw()
    {
    }
}
