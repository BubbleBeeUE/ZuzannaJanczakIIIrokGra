using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    

    private void Start()
    {
        
    }

    float score = 0;

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Collectables")
        {

            Destroy(collision.gameObject);
            score++;
            Debug.Log("Liczba próbek " + score);
                    
        }
        
    }

}
