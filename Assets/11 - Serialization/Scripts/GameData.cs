using UnityEngine;

namespace Serialization
{
    [System.Serializable]
    public class GameData
    {
        // Vector3's can't be serialized by C#, so we made a float array
        // and a property instead.
        public Vector3 Position => new Vector3(position[0], position[1], position[2]);

        public Character knight;
        public Character wizard;
        public Character rogue;

        public float[] position = new float[3];

        public GameData()
        {
            knight = new Character("Knight", 18, 10, 15, 7, 17, 10, 1);
            wizard = new Character("Wizard", 10, 18, 12, 17, 10, 12, 1);
            rogue = new Character("Rogue", 12, 16, 15, 12, 10, 18, 1);

            // Sets everything to each other in the order right to left.
            position[0] = position[1] = position[2] = 0;
        }
    }
}