using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MarchingCube))]
public class MarchCubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;
        using var hLayout = new EditorGUILayout.HorizontalScope();
        
        if (GUILayout.Button("Generate"))
        {
            var marchCube = target as MarchingCube;
            if (marchCube.is3D)
            {

                marchCube.PopulateTerrainMap3D();
            }
            else
            {

                marchCube.PopulateTerrainMap2D();
            }
            marchCube.CreateMeshData();
        }

        if (GUILayout.Button("Clear"))
        {
            var marchCube = target as MarchingCube;
            marchCube.Clear();
        }

        hLayout.Dispose();

        GUI.enabled = false;
    }
}