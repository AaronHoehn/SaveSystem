using UnityEngine;
using System.Collections.Generic;

public class SaveGameManager : MonoBehaviour
{
    // This scrip can be edited to set new variables to be saved

    public string saveName = "Save1"; // Default save name
    [SerializeField] private GameObject player;


    #region Saveable Variables

    public int playerLevel = 1;
    public int playerHealth = 300;

    public GameObject Player => player;

    #endregion


    /// <summary>
    /// Calls the SaveGame function of the SaveSystem if a name for the savegame is set
    /// </summary>
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


    /// <summary>
    /// Loads the saved data from the SaveData script if a saves savegame got selected
    /// </summary>
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
