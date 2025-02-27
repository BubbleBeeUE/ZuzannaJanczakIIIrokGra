using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject player;


    private void Start()
    {


    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Debug.Log("ZDERZENIE");
            GetComponent<MeshRenderer>().material.color = Color.red;

        }
    }
}