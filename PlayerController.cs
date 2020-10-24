using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletToright, bulletToleft;
    Vector2 bulletPos;
    public float speed = 1f;
    public float firerate = 0.5f;
    private void Start()
    {

    }
    void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");
            Vector3 moveVector = (transform.right * h);
            moveVector *= speed * Time.deltaTime;
            transform.localPosition += moveVector;
        }

    }
