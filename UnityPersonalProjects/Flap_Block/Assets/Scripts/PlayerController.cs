using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float flapForce = 10.0f;
    private Rigidbody playerRigid;
    private bool isOnGround = false;
    public bool gameOver = false;
    private int points = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //verticalInput = Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRigid.AddForce(Vector3.up * flapForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle")) {
            gameOver = true;
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            points = points + 1;
            Debug.Log("Your Current Points: " + points);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            points = points + 1;
            Debug.Log("Your Current Points: " + points);
        }
    }
}
