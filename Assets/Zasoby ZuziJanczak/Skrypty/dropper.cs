using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timetoDrop = 3f;
    MeshRenderer meshrenderer;
    Rigidbody rigibody;

    private void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        rigibody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Time.time > timetoDrop)
        {
            meshrenderer.enabled = true;
            rigibody.useGravity = true;
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}

