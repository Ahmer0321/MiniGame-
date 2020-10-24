using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    float maxSpeed = 1f;
    // Update is called once per frame
    void Start()
    {
       
    }


    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, 0, maxSpeed * Time.deltaTime);
        pos += transform.rotation * velocity;

        transform.position = pos;


    }
}