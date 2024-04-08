using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform sphere;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - sphere.transform.position;
    }

    void Update()
    {
        transform.position = sphere.transform.position + offset;
        transform.LookAt(sphere);
    }
}
