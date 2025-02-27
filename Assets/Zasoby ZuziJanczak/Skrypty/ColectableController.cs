using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkincontroller : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1f;
    Vector3 playerPosition;

    

    private void Start()
    {
        playerPosition = player.position;
    }

    private void Update()
    {
        transform.Rotate(0, 50* Time.deltaTime * speed, 20* Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, 100f);

    }
}