using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneticAlgorithm : MonoBehaviour
{
    public GameObject fishPrefab;
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
            GameObject fish = Instantiate(fishPrefab, spawnPoint.position, Quaternion.identity);
            population.Add(fish);

        }

        InvokeRepeating("NextGeneration", 5f, 5f);
    }

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
            GameObject fish = Instantiate(fishPrefab, spawnPoint.position, Quaternion.identity);
            population.Add (fish); 

        }

        generations--;

        if (generations == 0)
        {
            CancelInvoke("NextGeneration");
        }
    }
}
