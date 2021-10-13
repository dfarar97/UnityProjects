using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float shootTimer = 2.0f;
    private bool canShoot = true;

    // Update is called once per frame
    void Update()
    {

        
        

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (canShoot))
        {
            canShoot = false;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Debug.Log("hi");
            Invoke("ResetShoot", shootTimer);
        }
        
    }

    void ResetShoot()
    {

        canShoot = true;
    }
}
