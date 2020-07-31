using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ballget;
    void Update()
    {
        transform.position  = new Vector3(ballget.position.x -5 , ballget.position.y+2 , ballget.position.z);
    }
}
