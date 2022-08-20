using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKManager : MonoBehaviour
{
    public Joints Root;
    public Joints End;
    public Transform Target;    
    public float maxDis = 0.5f;
    public float rate = 5f;
    float calculateSlope(Joints joint)
    {
        float delta = 0.01f;
        float distance1 = GetDistance(End.transform.position, Target.transform.position);
        joint.Roatate(delta);
        float distance2 = GetDistance(End.transform.position, Target.transform.position);
        joint.Roatate(-delta);
        return (distance1 - distance2) / delta;
    }
    void Start()
    {
    }

    
    public float GetDistance(Vector3 point1, Vector3 point2)
    {
        return Vector3.Distance(point1, point2);
    }
    void Update()
    {
        if(GetDistance(End.transform.position, Target.transform.position) > maxDis)
        {
            Joints current = Root;
            while(current != null)
            {
                float slope = calculateSlope(current);
                current.Roatate(slope * rate);
                current = current.GetChild();
            }
        }
    }
}
