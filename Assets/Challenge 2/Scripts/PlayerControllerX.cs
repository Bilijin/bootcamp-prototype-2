using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float passedTime;


    private void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        passedTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (passedTime >= 1.0f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                passedTime = 0;
            }
        }

    }

    void getKey()
    {

    }
}
