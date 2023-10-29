using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FishBehavior))]
public class Fish : MonoBehaviour
{
    public float minSpeed = 2.0f;  
    public float maxSpeed = 5.0f;  
    public float minRotationSpeed = 10.0f;
    public float maxRotationSpeed = 40.0f;
    
    public float timeUntilNextTurn;

    public float minTurnInterval = 2.0f;  
    public float maxTurnInterval = 6.0f;  

    public float currentSpeed;
    public float currentRotationSpeed;

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
        // Example: Switch to a different behavior when a condition is met
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fishBehavior.SetBehavior(FishBehavior.BehaviorType.Feeding);
        }
    }


}
