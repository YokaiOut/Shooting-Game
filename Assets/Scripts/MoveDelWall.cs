using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDelWall : MonoBehaviour
{

    private float nextActionTime = 0.0f;
    private float period = 1.5f;

    private float Move = -0.03f;

    bool Switch = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;

            if (Switch == true)
            {
                Move = 0.01f;
                Switch = false;
            }
            else
            {
                if (Switch == false)
                {
                    Move = -0.01f;
                    Switch = true;
                }
            }
        }

        transform.position = transform.position + new Vector3(0, Move, 0);

    }
}