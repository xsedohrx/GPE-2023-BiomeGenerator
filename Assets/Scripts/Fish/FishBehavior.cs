using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script handles all of the fish behaviors
/// </summary>
public class FishBehavior : MonoBehaviour
{
    public enum BehaviorType
    {
        Swimming,
        Turning,
        Fleeing,
        Feeding,
        Exploring,
        Death
    }

    private BehaviorType currentBehavior;
    private Transform fishTransform;

    private void Start()
    {
        fishTransform = transform;
        // Initialize with a default behavior (e.g., Swimming)
        SetBehavior(BehaviorType.Swimming);
    }

    private void Update()
    {
        // Update the current behavior
        switch (currentBehavior)
        {
            case BehaviorType.Swimming:
                Swim();
                break;

            case BehaviorType.Turning:
                Turn();
                break;

            case BehaviorType.Fleeing:
                Flee();
                break;

            case BehaviorType.Feeding:
                Feed();
                break;

            case BehaviorType.Exploring:
                Explore();
                break;

            case BehaviorType.Death:
                Die();
                break;
        }
    }

    // Method for swimming behavior
    private void Swim()
    {
        // Implement swimming logic here
    }

    // Method for turning behavior
    private void Turn()
    {
        // Implement turning logic here
    }

    // Method for fleeing behavior
    private void Flee()
    {
        // Implement fleeing logic here
    }

    // Method for feeding behavior
    private void Feed()
    {
        // Implement feeding logic here
    }

    // Method for exploring behavior
    private void Explore()
    {
        // Implement exploring logic here
    }

    // Method for death behavior
    private void Die()
    {
        // Implement death logic here
    }

    // Method to set the current behavior
    public void SetBehavior(BehaviorType behaviorType)
    {
        currentBehavior = behaviorType;
    }
}
