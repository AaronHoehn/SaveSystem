using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    /// <summary>
    /// Saves the date from the sabeAbleObject into a Binary format on a path to a persistent data directory. C:\Users\<user>\AppData\LocalLow\<company name>
    /// </summary>
    /// <param name="player"></param>

    public static void SaveObject(SaveAbleObject saveAbleObject)
    {
        // save format
        BinaryFormatter formatter = new BinaryFormatter();

        // location to the operating system that is not changing
        string path = Application.persistentDataPath + "/saveObject.data";

        // Filestream to read and write to it
        FileStream stream = new FileStream(path, FileMode.Create);

        // data to get saved
        Data data = new Data(saveAbleObject);

        // write data to the file
        formatter.Serialize(stream, data);
        stream.Close();
    }


    /// <summary>
    /// Loads the saved data from C:\Users\<user>\AppData\LocalLow\<company name>
    /// </summary>
    public static Data LoadObject()
    {
        string path = Application.persistentDataPath + "/saveObject.data";
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
