using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] SpawnObjects;

    //private float nextActionTime = 0.0f;
    //private float period = 15.5f;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        //if (Time.time > nextActionTime)
        //{
        //    nextActionTime += period;
        //    int rand = Random.Range(0, SpawnObjects.Length);
        //    Instantiate(SpawnObjects[rand], transform.position, Quaternion.identity);
        //}
    }

    public void Spawn()
    {
        int rand = Random.Range(0, SpawnObjects.Length);
        Instantiate(SpawnObjects[rand], transform.position, Quaternion.identity);
    }
}