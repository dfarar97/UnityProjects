using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // this will detect collisions.. part of MonoBehavior
    {
        Destroy(gameObject); // destroys the food
        Destroy(other.gameObject); // destroys the animal
    }
}
