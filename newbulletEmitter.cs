using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbulletEmitter : MonoBehaviour
{
    public GameObject bulletEmiter;
    public GameObject bullet;
    public float bulletForwardForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet, bulletEmiter.transform.position, bulletEmiter.transform.rotation) as GameObject;
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.forward * bulletForwardForce);
            Destroy(Temporary_Bullet_Handler, 2f);
        }
    }
}