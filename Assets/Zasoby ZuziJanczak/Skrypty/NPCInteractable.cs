using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NPCInteractable : MonoBehaviour
{

    [SerializeField] UnityEvent talking;



    public void Interact()
    {
        Debug.Log("Interact");
    }
}
