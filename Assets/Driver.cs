using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 15f;
    void Start()
    {
        // transform.Rotate(0,0,50);
    }

    // Update is called once per frame
    void Update()
    {
        // GetAxis for moving direction from the Keyboard
        float horizontalSpeed = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float verticalSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -horizontalSpeed);
        transform.Translate(0, verticalSpeed, 0);
    }
}
