using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnObject : MonoBehaviour
{
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 jiggle = new Vector3(
            position.x,
            position.y + Random.value,
            position.z);
        this.transform.position = jiggle;
        this.transform.localEulerAngles = rotation;
        this.transform.
    }
}
