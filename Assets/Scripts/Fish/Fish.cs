using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FishBehavior))]
public class Fish : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Vector2 genes;
    public int health;


    public FishBehavior fishBehavior; // Reference to the FishBehavior script

    private void Start()
    {
        // Initialize with the default behavior (e.g., Swimming)
        fishBehavior.SetBehavior(FishBehavior.BehaviorType.Swimming);
    }

    private void Update()
    {
        // Example: Switch to a different behavior when a condition is met
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fishBehavior.SetBehavior(FishBehavior.BehaviorType.Feeding);
        }
    }


}
