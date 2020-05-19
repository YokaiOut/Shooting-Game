using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float MouseSense = 100f;

    public Transform PlayerBody;

    float XRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSense * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSense * Time.deltaTime;

        XRotation -= MouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 52f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * MouseX);
    }
}
