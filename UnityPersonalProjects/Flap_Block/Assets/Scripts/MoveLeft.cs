using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveLeft : MonoBehaviour
{
    private float speed = 5.0f;
    private PlayerController playerControllerScript;


    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if(playerControllerScript.gameOver == true)
        {
            speed = 0.0f;
        }
    }
}
