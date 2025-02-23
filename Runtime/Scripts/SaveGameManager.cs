using UnityEngine;
using System.Collections.Generic;

public class SaveGameManager : MonoBehaviour
{
    public string saveName = "Save1"; // Default save name
    [SerializeField] private GameObject player;

    #region Saveable Variables

    public int playerLevel = 4;
    public int playerHealth = 40;

    public GameObject Player => player;

    #endregion

    public void SaveGame()
    {
        if (string.IsNullOrEmpty(saveName))
        {
            Debug.LogError("Save name cannot be empty!");
            return;
        }

        SaveSystem.SaveGame(this, saveName);
        Debug.Log("Game Saved: " + saveName);
    }

    public void LoadGame()
    {
        if (string.IsNullOrEmpty(saveName))
        {
            Debug.LogError("Save name cannot be empty!");
            return;
        }

        SaveData saveData = SaveSystem.LoadGame(saveName);
        if (saveData != null)
        {
            playerLevel = saveData.playerLevel;
            playerHealth = saveData.playerHealth;

            Vector3 position;
            position.x = saveData.playerPosition[0];
            position.y = saveData.playerPosition[1];
            position.z = saveData.playerPosition[2];
            player.transform.position = position;

            Debug.Log("Game Loaded: " + saveName);
        }
    }

    public List<string> GetSaveFiles()
    {
        return SaveSystem.GetSaveFiles();
    }
}
