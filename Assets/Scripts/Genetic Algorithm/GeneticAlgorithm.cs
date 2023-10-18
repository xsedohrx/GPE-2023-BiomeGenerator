using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneticAlgorithm : MonoBehaviour
{
    public GameObject eggPrefab;
    public Transform spawnPoint;
    public int populationSize = 10, generations = 3;

    private List<GameObject> population = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        StartSimulation();        
    }

    void StartSimulation() {
        for (int i = 0; i < populationSize; i++)
        {
            GameObject fish = Instantiate(eggPrefab, spawnPoint.position, Quaternion.identity);
            population.Add(fish);

        }

        InvokeRepeating("NextGeneration", 5f, 5f);
    }

    //BoxCollider boxCollider; 

    //// Calculate random position within the Box Collider boundaries
    //Vector3 randomPosition = new Vector3(
    //    Random.Range(boxCollider.bounds.min.x, boxCollider.bounds.max.x),
    //    Random.Range(boxCollider.bounds.min.y, boxCollider.bounds.max.y),
    //    Random.Range(boxCollider.bounds.min.z, boxCollider.bounds.max.z)
    //);


    void NextGeneration() {
        foreach (var fish in population)
        {

            //TODO

            if (fish.GetComponent<Fish>().speed < 3)
            {

                Destroy(fish);
            }

        }

        population.Clear();

        for (int i = 0; i < populationSize; i++)
        {
            GameObject fish = Instantiate(eggPrefab, spawnPoint.position, Quaternion.identity);
            population.Add (fish); 

        }

        generations--;

        if (generations == 0)
        {
            CancelInvoke("NextGeneration");
        }
    }
}
