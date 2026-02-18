using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveMission(string[] status)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fun";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            MissionData data = new MissionData(status);
            formatter.Serialize(stream, data);
        }

        Debug.Log("Mission saved at: " + path);
    }

    public static MissionData LoadMission()
    {
        string path = Application.persistentDataPath + "/player.fun";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                MissionData data = formatter.Deserialize(stream) as MissionData;
                return data;
            }
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
    public static void SaveCollection(string[] character)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/collection.fun";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            CollectionData data = new CollectionData(character);
            formatter.Serialize(stream, data);
        }

        Debug.Log("Collection saved at: " + path);
    }

    public static CollectionData LoadCollection()
    {
        string path = Application.persistentDataPath + "/collection.fun";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                CollectionData data = formatter.Deserialize(stream) as CollectionData;
                return data;
            }
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
