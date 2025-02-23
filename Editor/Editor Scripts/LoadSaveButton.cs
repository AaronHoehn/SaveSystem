using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveGameManager))]

public class LoadSaveButton : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SaveGameManager saveGameManager = (SaveGameManager)target;

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Save"))
        {
            saveGameManager.SaveGame();
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(); 

        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("Load"))
        {
            saveGameManager.LoadGame();
        }
        EditorGUILayout.EndHorizontal();
    }
}
