using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{

   
    public AudioSource footstepsSound;


    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; 

        if (direction.magnitude > 0.1f)
        {
            
           footstepsSound.enabled = true;
              
            
        }
        else
        {
            footstepsSound.enabled = false;
            
        }
    }
}
