using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{

    BulletPool _intanciate;


    public GameObject[] Bullets;


    public BulletPool Instantiate()
    {
        _intanciate = this;
        return _intanciate;
    }

    private void Start()
    {
        
    }



    public bool Shoot()
    {

        for (int i = 0; i < Bullets.Length; i++)
        {
            if (Bullets[i].gameObject.activeSelf == false)
            {
                Debug.Log("Dispara");
                Bullets[i].SetActive(true);
                //Bullets[i].GetComponent<>();
                return true;
            }

        }

        return false;
    }



}
