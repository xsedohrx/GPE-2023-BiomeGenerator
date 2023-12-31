using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField] private GameObject fishPrefab;
    public float hatchTime = 3f;
    float hatchTimer;
    bool hasHatched;

    private void Start()
    {
        hatchTimer = hatchTime;    
    }

    private void Update()
    {
        HatchingProcess();
    }

    private void HatchingProcess()
    {
        if (!hasHatched)
        {
            hatchTime -= Time.deltaTime;
            if (hatchTime < 0)
            {
                HatchFish();
            }
        }
    }

    void HatchFish() {
        hasHatched = true;
        if (hasHatched)
        {
            GameObject newFish = Instantiate(fishPrefab, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
