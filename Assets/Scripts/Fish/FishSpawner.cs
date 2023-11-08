using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{

    [SerializeField] GameObject fishPrefab;
    Vector3 spawnPosition;
    MarchingCube cube;

    private void OnEnable()
    {
        cube = transform.parent.GetComponent<MarchingCube>();
        for (int i = 0; i < cube.spawnPositions.Count; i++)
        {
            spawnPosition = cube.spawnPositions[i].position;
            GameObject fish = Instantiate(fishPrefab,spawnPosition, Quaternion.identity);
        }
    }


}
