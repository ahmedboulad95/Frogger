using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public bool isLeft = false;

    private void Start()
    {
        if(transform.position.x < 0)
        {
            isLeft = true;
        }
    }

    void Update()
    {
        Vector2 carPos = transform.position;

        int multiplier = 1;
        if(isLeft)
        {
            multiplier = -1;
        }

        carPos.x -= multiplier * moveSpeed * Time.deltaTime;
        transform.position = carPos;

        if(isLeft)
        {
            carPos.x *= -1;
        }

        if (carPos.x < -9.0f)
        {
            Destroy(gameObject);
        }
    }
}
