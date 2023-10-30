using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script handles all of the fish behaviors
/// </summary>
public class FishBehavior : MonoBehaviour
{
    Fish fish;

    public enum BehaviorType
    {
        Swimming,
        Fleeing,
        Feeding,
        Exploring,
        Death
    }

    public BehaviorType currentBehavior;

    private void Start()
    {
        fish = GetComponent<Fish>();
        SetBehavior(BehaviorType.Swimming);
    }

    private void Update()
    {
        HandleBehavior();
    }

    private void HandleBehavior()
    {

        switch (currentBehavior)
        {
            case BehaviorType.Swimming:
                Swim();
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

    private void Swim()
    {
        // Implement swimming logic here
        float swimSpeed = Mathf.Clamp(fish.currentSpeed, fish.minSpeed, fish.maxSpeed);
        transform.Translate(transform.forward * swimSpeed * Time.deltaTime, Space.World);

        // Check if it's time to turn
        fish.timeUntilNextTurn -= Time.deltaTime;
        if (fish.timeUntilNextTurn <= 0)
        {
            LerpRotateRandomly();
            fish.timeUntilNextTurn = Random.Range(fish.minTurnInterval, fish.maxTurnInterval);
        }
    }


    private void Flee()
    {
        // Implement fleeing logic here
    }

    private void Feed()
    {
        // Implement feeding logic here
    }

    private void Explore()
    {
        // Implement exploring logic here
    }

    private void Die()
    {
        // Implement death logic here
    }

    public void SetBehavior(BehaviorType behaviorType)
    {
        currentBehavior = behaviorType;
    }

    private void LerpRotateRandomly()
    {
        // Calculate the target rotation
        Quaternion targetRotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);

        // Determine the rotation duration based on the rotation speed
        float rotationDuration = 1f / fish.currentRotationSpeed;

        // Start the rotation coroutine
        StartCoroutine(RotateOverTime(targetRotation, rotationDuration));
    }


    //Coroutine used for determining when to rotate fish
    private IEnumerator RotateOverTime(Quaternion targetRotation, float duration)
    {
        float elapsedTime = 0f;
        Quaternion initialRotation = transform.rotation;

        while (elapsedTime < duration)
        {
            transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.rotation = targetRotation;
    }

}
