using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public class SaveLoadSystem : MonoBehaviour
    {
        // Streaming assets is a folder that Unity creates that we can use
        // to load/save data in, in the Editor it is in the project folder,
        // in a build, it is in the .exe's build folder
        private string FilePath => Application.streamingAssetsPath + "/gameData";

        [SerializeField] private bool useBinary = false;
        [SerializeField] private GameData gameData = new GameData();

        private void Start()
        {
            if(!Directory.Exists(Application.streamingAssetsPath))
                Directory.CreateDirectory(Application.streamingAssetsPath);
        }

        private void Save()
        {
            if(useBinary)
                SaveBinary();
            else
                // WILSOOOOOOON
                SaveJson();
        }

        private void SaveBinary()
        {
            // This opens the 'River' between the RAM and the file
            using(FileStream stream = new FileStream(FilePath + ".save", FileMode.OpenOrCreate))
            {
                // Like creating the boat that will carry the data from one point to another
                BinaryFormatter formatter = new BinaryFormatter();
                // Transports the data from the RAM to the specified file, like freezing water
                // into ice.
                formatter.Serialize(stream, gameData);
            }
        }

        private void SaveJson()
        {
            // Converts the object to a JSON string that we can read/write
            // to and from a file
            string json = JsonUtility.ToJson(gameData);
            // This will write all the contents of the string (param 2) to the 
            // file at the path (param 1), the standard is to use .json as the file
            // extension for json files.
            File.WriteAllText(FilePath + ".json", json);
        }

        void Load()
        {
            if(useBinary)
                LoadBinary();
            else
                LoadJson();
        }

        private void LoadBinary()
        {
            // If there is no save data, we shouldn't attempt to load it
            if(!File.Exists(FilePath + ".save"))
                return;

            // This opens the 'River' between the RAM and the file
            using(FileStream stream = new FileStream(FilePath + ".save", FileMode.Open))
            {
                // Like creating the boat that will carry the data from one point to another
                BinaryFormatter formatter = new BinaryFormatter();
                // Transports the data from the specified file to the RAM, like unfreezing ice
                // into water.
                gameData = formatter.Deserialize(stream) as GameData;
            }
        }

        private void LoadJson()
        {
            // This is how we read the string data from a file
            string json = File.ReadAllText(FilePath + ".json");
            // This is how you convert the json back to a data type.
            // The Generic is required for making sure the returned data
            // is the same as the passed in
            gameData = JsonUtility.FromJson<GameData>(json);
        }

        private void OnGUI()
        {
            if(GUILayout.Button("Save"))
                // Do that save thing you've been talking about
                Save();

            if(GUILayout.Button("Load"))
                // Do that load thing you've been talking about
                Load();
        }
    }
}