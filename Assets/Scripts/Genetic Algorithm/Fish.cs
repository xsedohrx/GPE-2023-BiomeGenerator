using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Vector2 genes;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        genes = new Vector2(Random.Range(1f,5f), Random.Range(10f, 180f));
        speed = genes.x;
        rotationSpeed = genes.y;
    }

    // Update is called once per frame
    void Update()
    {
        MoveFish();
        RotateFish();
    }

    private void MoveFish()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void RotateFish()
    {
        transform.Rotate(0, 0, Random.Range(-rotationSpeed, rotationSpeed) * Time.deltaTime);
    }
}
