using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float Delay = 20f;

    // Update is called once per frame
    void Update()
    {
        Delay -= 0.5f; 

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Delay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Delay = 20f;
        }
    }
}
