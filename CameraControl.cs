using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public GameObject Player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - Player.transform.position;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(target);
        transform.position = Player.transform.position + offset;
    }
}
