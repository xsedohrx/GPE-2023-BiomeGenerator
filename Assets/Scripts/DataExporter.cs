using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace BiomeData{

    public class DataExporter : MonoBehaviour
    {

        public string fileName = "terrain_data.txt";

        private void OnEnable()
        {
            // Find all MarchingCube components in the scene
            MarchingCube[] marchingCubes = FindObjectsOfType<MarchingCube>();

            // Create the file and write the values for each MarchingCube
            StreamWriter writer = new StreamWriter(fileName);

            foreach (MarchingCube marchingCube in marchingCubes)
            {
                Vector3 offset = marchingCube.offset;
                string cubeName = marchingCube.cubeName;
                float terrainSurface = marchingCube.terrainSurface;
                int width = marchingCube.width;
                int height = marchingCube.height;
                float platformHeight = marchingCube.platformHeight;
                Vector3 position = marchingCube.transform.position;
                Quaternion rotation = marchingCube.transform.rotation;

                writer.WriteLine("Cube Name: " + cubeName);
                writer.WriteLine("Object Position: " + position);
                writer.WriteLine("Object Rotation: " + rotation);
                writer.WriteLine("Offset: " + offset.ToString());
                writer.WriteLine("Terrain Surface: " + terrainSurface);
                writer.WriteLine("Width: " + width);
                writer.WriteLine("Height: " + height);
                writer.WriteLine("Platform Height: " + platformHeight);
                writer.WriteLine(); // Add a blank line to separate each MarchingCube data
            }

            writer.Close();

            Debug.Log("Data exported to " + fileName);
        }
    }

}