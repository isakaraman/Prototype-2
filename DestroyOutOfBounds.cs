using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] float ProjectileBoundry;
    [SerializeField] float AnimalBoundry;
    void Update()
    {
        //if an object goes past the players view in the game, destroy that object
        if (transform.position.z > ProjectileBoundry)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < AnimalBoundry)
        {
            Destroy(gameObject);
        }
        if (transform.position.x>30 || transform.position.x < -30)
        {
            Destroy(gameObject);
        }
    }
}
