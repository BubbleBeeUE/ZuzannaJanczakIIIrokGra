using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collectables : MonoBehaviour
{

    private int Fiolka = 0;

    public TextMeshProUGUI fiolkaText;

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

            fiolkaText.text = "Liczba zebranych fiolek: " + score;


        }
        
    }

}
