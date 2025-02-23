using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public int playerLevel = 4;
    public int playerHealth = 40;
    public GameObject Player => player;

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
        Debug.Log("Saved");
    }

    public void LoadGame()
    {
        SaveData saveData = SaveSystem.Loadgame();

        playerLevel = saveData.playerLevel;
        playerHealth = saveData.playerHealth;

        Vector3 position;
        position.x = saveData.playerPosition[0];
        position.y = saveData.playerPosition[1];
        position.z = saveData.playerPosition[2];
        player.transform.position = position;
        Debug.Log("Loaded");
    }
}
