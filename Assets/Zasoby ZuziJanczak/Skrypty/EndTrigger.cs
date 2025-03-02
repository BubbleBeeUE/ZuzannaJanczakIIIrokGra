using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Koniec gry");

        onTriggerEnter.Invoke();

      
    }


    private void OnTriggerExit(Collider other)
    {
       


    }
}
   

  

    
