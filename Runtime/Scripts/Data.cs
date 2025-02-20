using UnityEngine;

[System.Serializable]
public class Data
{
    public int level;
    public int health;
    public float[] position;

    public Data (SaveAbleObject saveAbleObject) 
    {
        level = saveAbleObject.level;
        health = saveAbleObject.health;

        position = new float[3];
        position[0] = saveAbleObject.transform.position.x;
        position[1] = saveAbleObject.transform.position.y;
        position[2] = saveAbleObject.transform.position.z;
    }
}
