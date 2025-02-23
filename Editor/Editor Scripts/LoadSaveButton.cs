using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(SaveGameManager))]
public class LoadSaveButton : Editor
{
    private string newSaveName = "";
    private int selectedSaveIndex = 0;
    private List<string> saveFiles = new List<string>();

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SaveGameManager saveGameManager = (SaveGameManager)target;

        // Update available save files
        saveFiles = saveGameManager.GetSaveFiles();
        if (saveFiles.Count == 0)
        {
            saveFiles.Add("No Saves Found");
        }

        EditorGUILayout.LabelField("Save Name:");
        newSaveName = EditorGUILayout.TextField(newSaveName);

        if (GUILayout.Button("Save Game"))
        {
            if (!string.IsNullOrEmpty(newSaveName))
            {
                saveGameManager.saveName = newSaveName;
                saveGameManager.SaveGame();
                newSaveName = ""; // Clear after saving
                saveFiles = saveGameManager.GetSaveFiles(); // Refresh save list
            }
            else
            {
                Debug.LogError("Enter a save name before saving.");
            }
        }

        EditorGUILayout.Space();

        // Save file selection dropdown
        selectedSaveIndex = EditorGUILayout.Popup("Select Save", selectedSaveIndex, saveFiles.ToArray());

        if (GUILayout.Button("Load Selected Save"))
        {
            if (saveFiles[selectedSaveIndex] != "No Saves Found")
            {
                saveGameManager.saveName = saveFiles[selectedSaveIndex];
                saveGameManager.LoadGame();
            }
            else
            {
                Debug.LogError("No valid save file selected.");
            }
        }
    }
}
