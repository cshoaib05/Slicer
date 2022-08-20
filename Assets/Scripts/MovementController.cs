using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Joystick Joystick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Joystick.Horizontal;// Input.GetAxis("Horizontal");
        float vertical = Joystick.Vertical;// Input.GetAxis("Vertical");

        Vector3 tempPos = transform.position;
        tempPos += new Vector3(horizontal * Time.deltaTime,vertical * Time.deltaTime);
        transform.position = tempPos;
    }
}
