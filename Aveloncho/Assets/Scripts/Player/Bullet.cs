using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    float time;
    public float bulletTime;

    Rigidbody rb;

    void Start()
    {
        rb.GetComponent<Rigidbody>();
        time = 0;
    }

    void Update()
    {

        Move();
    }


    void Move()
    {

        time += Time.deltaTime;

        if (time >= bulletTime)
        {
            this.gameObject.SetActive(false);

        }
    }
}