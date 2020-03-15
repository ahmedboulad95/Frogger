using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        Vector2 playerPosition = transform.position;

        if(Input.GetKeyDown("w"))
        {
            playerPosition.y++;
        }
        else if(Input.GetKeyDown("s"))
        {
            playerPosition.y--;
        }
        else if(Input.GetKeyDown("a"))
        {
            playerPosition.x--;
        }
        else if(Input.GetKeyDown("d"))
        {
            playerPosition.x++;
        }

        transform.position = playerPosition;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            Debug.Log("You lost");
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Goal")
        {
            Debug.Log("You win");
        }
    }
}
