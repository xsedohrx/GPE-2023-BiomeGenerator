using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BiomeScriptableObject))]
public class BiomeDesigner : EditorWindow
{

    BiomeScriptableObject biomeSO;
    private List<GameObject> biomes;

    #region DrawGUI
    [MenuItem("Custom Menu/Open custom Window", false, 1)]
    public static void OpenWindow()
    {
        BiomeDesigner window = GetWindow<BiomeDesigner>("Custom Window");
        window.Show();
    }

    private void OnGUI() { DrawBiomeEditorDesigner(); }

    private void DrawBiomeEditorDesigner()
    {

        GUILayout.Box("Biome Designer", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
        GUILayout.BeginArea(new Rect(10, 60, position.width - 20, position.height - 20));
        DrawBiomeProperties();
        DrawGenerateButtons();

        GUILayout.EndArea();
    }

    private void DrawBiomeProperties()
    {
        //GUILayout.Label(, GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.TextArea("Welcome to Biome Designer" + System.Environment.NewLine + "Insert a Biome Scriptable Object to start editing the biome properties");
        biomeSO = (BiomeScriptableObject)EditorGUILayout.ObjectField("Biome SO", biomeSO, typeof(BiomeScriptableObject), false);
        GUILayout.Label("X:", GUILayout.Width(200), GUILayout.Height(20));
        biomeSO.biomeWidth = GUILayout.HorizontalSlider(biomeSO.biomeWidth, 0.0f, 1.0f);
        GUILayout.Label(" ", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Label("Y:", GUILayout.Width(200), GUILayout.Height(20));
        biomeSO.biomeHeight = GUILayout.HorizontalSlider(biomeSO.biomeHeight, 0.0f, 1.0f);
        GUILayout.Label(" ", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Label("Z:", GUILayout.Width(200), GUILayout.Height(20));
        biomeSO.biomeDepth = GUILayout.HorizontalSlider(biomeSO.biomeDepth, 0.0f, 1.0f);
        GUILayout.Label(" ", GUILayout.Width(200), GUILayout.Height(20));
    }

    private void DrawGenerateButtons()
    {
        if (GUILayout.Button("Generate Biome"))
        {
            GameObject biome = Instantiate(biomeSO.biomePrefab.gameObject);
            //biome.AddComponent<MarchingCube>();
            biomes.Add(biome);
        }

        if (GUILayout.Button("Delete all biomes"))
        {
            foreach (GameObject biome in biomes)
            {
                DestroyImmediate(biome);
            }
            biomes.Clear();
        }
    }


    #endregion


}

