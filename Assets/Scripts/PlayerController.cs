using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horInput;
    public float speed = 10.0f;
    public int range = 20;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -range )
        { transform.position = new Vector3(-range, transform.position.y, transform.position.z); } 
        if(transform.position.x > range)
        { transform.position = new Vector3(range, transform.position.y, transform.position.z); }

        horInput = Input.GetAxis("Horizontal");
        transform.Translate(horInput * speed * Time.deltaTime * Vector3.right);

        if(Input.GetKeyDown(KeyCode.Space))
        { Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); }
    }
}
