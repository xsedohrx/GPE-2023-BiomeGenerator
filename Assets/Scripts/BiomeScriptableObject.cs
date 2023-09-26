using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BiomeSO", menuName = "Scriptable Objects/Biome")]
public class BiomeScriptableObject : ScriptableObject
{
    [Header("Biome Properties")]
    public int index;
    public string bioName;

    [Header("Biome Shape")]
    [Range(0, 200)]
    public float biomeWidth;
    [Range(0, 200)]
    public float biomeHeight;
    [Range(0, 200)]
    public float biomeDepth;

    [Header("Biome Terrain")]
    public GameObject biomePrefab;
    public Material terrainMaterial;
    public int minSubBiomes;
    public int maxSubBiomes;

    [Header("Biome Lifeforms")]
    public List<GameObject> plants;
    public List<GameObject> rocks;
    public List<GameObject> lifeForms;

    

}
