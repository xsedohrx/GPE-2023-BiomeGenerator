using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FishBehavior))]
public class Fish : MonoBehaviour
{
    public float minSpeed = 2.0f, maxSpeed = 5.0f, minRotationSpeed = 10.0f, maxRotationSpeed = 40.0f, timeUntilNextTurn, 
    minTurnInterval = 2.0f, maxTurnInterval = 6.0f, currentSpeed, currentRotationSpeed;
    
    public int hunger;

    [SerializeField] public FishBehavior fishBehavior;

    private void Start()
    {
        fishBehavior.SetBehavior(FishBehavior.BehaviorType.Swimming);
        currentSpeed = Random.Range(minSpeed, maxSpeed);
        currentRotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){ fishBehavior.SetBehavior(FishBehavior.BehaviorType.Feeding);}
    }
}
