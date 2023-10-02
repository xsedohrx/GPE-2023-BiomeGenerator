using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BiomeSO", menuName = "Scriptable Objects/Biome")]
public class BiomeScriptableObject : ScriptableObject
{
    [Header("Biome Properties"), Tooltip("")]
    public int index;
    public string bioName;

    [Header("Biome Shape"), Tooltip("Properties used to change the size of the Biome")]
    [Range(0, 200)] public float biomeWidth;
    [Range(0, 200)] public float biomeHeight;
    [Range(0, 200)] public float biomeDepth;

    [Header("Biome Terrain"), Tooltip("Terrain properties like material, how many habitats there are etc.")]
    public GameObject biomePrefab;
    public Material terrainMaterial;
    public int minSubBiomes;
    public int maxSubBiomes;

    [Header("Biome Lifeforms"), Tooltip("Properties for lifeforms held in the current Biome.")]
    public List<GameObject> plants;
    public List<GameObject> rocks;
    public List<GameObject> lifeForms;

}
