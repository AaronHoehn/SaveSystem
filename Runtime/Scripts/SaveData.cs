using UnityEngine;

[System.Serializable]
public class SaveData
{
    public int playerLevel;
    public int playerHealth;
    public float[] playerPosition;

    public SaveData (SaveGameManager saveGameManager) 
    {
        playerLevel = saveGameManager.playerLevel;
        playerHealth = saveGameManager.playerHealth;

        playerPosition = new float[3];
        playerPosition[0] = saveGameManager.Player.transform.position.x;
        playerPosition[1] = saveGameManager.Player.transform.position.y;
        playerPosition[2] = saveGameManager.Player.transform.position.z;
    }
}
