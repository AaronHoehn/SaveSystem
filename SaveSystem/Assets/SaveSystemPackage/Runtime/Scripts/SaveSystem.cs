using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="player"></param>
    public static void SavePlayer(Player player)
    {
        // save format
        BinaryFormatter formatter = new BinaryFormatter();

        // location to the operating system that is not changing
        string path = Application.persistentDataPath + "/player.data";

        // Filestream to read and write to it
        FileStream stream = new FileStream(path, FileMode.Create);

        // data to get saved
        Data data = new Data(player);

        // write data to the file
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Data LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.data";
        if (File.Exists(path))
        {
            // Open file 
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream  = new FileStream(path, FileMode.Open);

            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
