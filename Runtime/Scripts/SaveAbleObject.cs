using UnityEngine;

public class SaveAbleObject : MonoBehaviour
{
    public int level = 4;
    public int health = 40;

    public void SaveObject()
    {
        SaveSystem.SaveObject(this);
        Debug.Log("Saved");
    }

    public void LoadObject()
    {
        Data data = SaveSystem.LoadObject();

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        Debug.Log("Loaded");
    }
}
