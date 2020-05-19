using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        else
        {
            if (col.gameObject.tag == "Lvl")
            {
                Destroy(gameObject);
            }
            else
            {
                if (col.gameObject.tag == "Enemy")
                {
                    Destroy(gameObject);
                    Destroy(col.gameObject);
                }
            }
        }
    }
}
