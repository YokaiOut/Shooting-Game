using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    // Assign by dragging the GameObject with ScriptA into the inspector before running the game.
    public SpawnScript Walls;

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
        //bullet Collision
        if (gameObject.tag == "Bullet")
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

        //DeathWall (Rand Walls) Collision
        if (gameObject.tag == "DeleteWall")
        {
            if (col.gameObject.tag == "SpawnWall")
            {
                Destroy(col.gameObject);
                Walls.Spawn();
            }
            else
            {
                if (col.gameObject.tag == "Wall")
                {
                    Destroy(col.gameObject);
                }
            }
        }

        //DeathWall (Enemy) Collision
        if (gameObject.tag == "DeleteEnemy")
        {
            if (col.gameObject.tag == "Enemy")
            {
                Destroy(col.gameObject);
            }
        }

    }
}

