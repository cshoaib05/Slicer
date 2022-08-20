using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joints : MonoBehaviour
{
    public Joints child;


    public Joints GetChild()
    {
        return child;
    }


    public void Roatate(float angle)
    {
        transform.Rotate(Vector3.up * angle);
    }

    void Update()
    {
        
    }
}
