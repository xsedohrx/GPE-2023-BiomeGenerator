using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BiomeDesigner : EditorWindow
{
    private float sliderValue;

    [MenuItem("Custom Menu/Open custom Window")]
    public static void OpenWindow() { 
        BiomeDesigner window = GetWindow<BiomeDesigner>("Custom Window");
        window.Show();
    }

    private void OnGUI()
    {
        DrawEditorWindow();
    }

    private void DrawEditorWindow()
    {
        GUILayout.Box("Biome Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
        GUILayout.BeginArea(new Rect(10, 30, position.width - 20, position.height - 20));
        GUILayout.Label("Welcome to Biome Designer,", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Label("Generate your Biome", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Label("X:", GUILayout.Width(200), GUILayout.Height(20));
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 1.0f);
        GUILayout.Label(" ", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Label("Y:", GUILayout.Width(200), GUILayout.Height(20));
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 1.0f);
        GUILayout.Label(" ", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Label("Z:", GUILayout.Width(200), GUILayout.Height(20));
        sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 1.0f);
        GUILayout.Label(" ", GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.Button("Generate Biome");
        GUILayout.EndArea();
    }
}
