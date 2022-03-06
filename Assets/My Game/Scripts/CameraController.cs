using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Target;

    private Vector3 Distance;
    // Start is called before the first frame update
    void Start()
    {
        Distance = Target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 local = Target.position - Distance;
        transform.position = local;
    }
}
