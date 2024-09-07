using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorCounterApp : EditorWindow
{
   [MenuItem("EditorConterApp/Open")]
   static void Open()
    {
        var window = GetWindow<EditorCounterApp>();
        window.position = new Rect(x: 100, y: 100, width: 400, height: 600);
        window.titleContent = new GUIContent(text:nameof(EditorCounterApp));
        window.Show();
    }
    private void OnGUI()
    {
        if (GUILayout.Button(text:"+"))
        {
            new AddCountCommand()
                .Execute();
        }

        //GUILayout.Label(text:CountModel.Instance.Count.Value.ToString());

        if (GUILayout.Button(text:"-"))
        {
            new SubCountCommand()
                .Execute();
        }
    }
}
