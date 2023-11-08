using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{

    [SerializeField] GameObject fishPrefab;
    Vector3 spawnPosition;


    private void OnEnable()
    {
        GameObject fish = Instantiate(fishPrefab,spawnPosition, Quaternion.identity);
    }


}
