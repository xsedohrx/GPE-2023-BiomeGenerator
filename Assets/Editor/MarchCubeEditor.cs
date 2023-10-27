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
            marchCube.PopulateTerrainMap();
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