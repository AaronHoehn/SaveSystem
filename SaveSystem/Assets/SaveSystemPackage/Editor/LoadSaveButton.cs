using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveAbleObject))]

public class LoadSaveButton : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SaveAbleObject saveAbleObject = (SaveAbleObject)target;

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Save"))
        {
            saveAbleObject.SaveObject();
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(); 

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Load"))
        {
            saveAbleObject.LoadObject();
        }
        EditorGUILayout.EndHorizontal();
    }
}
