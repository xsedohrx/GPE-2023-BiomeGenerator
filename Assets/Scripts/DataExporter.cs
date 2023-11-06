using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataExporter : MonoBehaviour
{
    public string fileName = "terrain_data.txt";

    private void OnEnable()
    {
        // Get the values from your MarchingCube script
        MarchingCube marchingCube = GetComponent<MarchingCube>();
        Vector3 offset = marchingCube.offset;
        string cubeName = marchingCube.cubeName;
        float terrainSurface = marchingCube.terrainSurface;
        int width = marchingCube.width;
        int height = marchingCube.height;
        float platformHeight = marchingCube.platformHeight;

        // Create the file and write the values
        StreamWriter writer = new StreamWriter(fileName);
        writer.WriteLine("Cube Name: " + cubeName);
        writer.WriteLine("Offset: " + offset.ToString());
        writer.WriteLine("Terrain Surface: " + terrainSurface);
        writer.WriteLine("Width: " + width);
        writer.WriteLine("Height: " + height);
        writer.WriteLine("Platform Height: " + platformHeight);
        writer.Close();

        Debug.Log("Data exported to " + fileName);
    }
}
