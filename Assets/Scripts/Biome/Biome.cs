using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class Biome : MonoBehaviour
{
    [SerializeField] private BiomeScriptableObject biomeSO;

    Mesh mesh;
    private Vector3[] verts;
    private int gridSizeX, gridSizeY, gridSizeZ;

    private void Start()
    {
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "BiomeMesh";

        gridSizeX = (int)biomeSO.biomeWidth + 1;
        gridSizeY = (int)biomeSO.biomeHeight + 1;
        gridSizeZ = (int)biomeSO.biomeDepth + 1;

        ///Create the lists of vector types used for updating vertex data
        verts = new Vector3[gridSizeX * gridSizeY * gridSizeZ];
        int[] triangles = new int[(gridSizeX -1) * (gridSizeY -1) * (gridSizeZ-1) *36];
        int vertIndex = 0;
        int triIndex = 0;


        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                for (int z = 0; z < gridSizeZ; z++)
                {
                    float xPos = x * 5;
                    float yPos = y * 5;
                    float zPos = z * 5;

                    ///Place vertex position and set other properties
                    verts[x + (y*gridSizeX) + (z*gridSizeX * gridSizeY)] = new Vector3(xPos, yPos, zPos);
                }
            }
        }

        ///set mesh properties
        mesh.vertices = verts.ToArray();
        mesh.triangles = triangles;
    }

    private void OnDrawGizmos()
    {
        if (mesh.vertices == null) return;
        Gizmos.color = Color.green;

        for (int i = 0; i < mesh.vertices.Length; i++)
        {
            Gizmos.DrawSphere(mesh.vertices[i], 0.1f);
        }
    }
}