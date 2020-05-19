using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public CharacterController Controller;

    public float Speed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 MoveObj = transform.right * X + transform.forward * Z;

        Controller.Move(MoveObj * Speed * Time.deltaTime);
    }
}
