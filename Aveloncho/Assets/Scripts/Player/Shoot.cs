
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{


    public BulletPool bullet;


    void Start()
    {
        bullet.Shoot();
    }


    void Update()
    {

    }


}