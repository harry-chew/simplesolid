using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform target;
 
    void FixedUpdate()
    {
        this.transform.position = new Vector3(target.position.x, target.position.y, this.transform.position.z);
    }
}
