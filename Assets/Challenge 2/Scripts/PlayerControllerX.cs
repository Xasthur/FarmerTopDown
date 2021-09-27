using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float antiSpam = 0.5f;
    float waitTime;

    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog
        waitTime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && waitTime >= antiSpam)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            waitTime = 0.0f;
        }
    }
}
