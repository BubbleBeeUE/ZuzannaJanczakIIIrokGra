using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// here we choose 'focus' and where to move

[RequireComponent(typeof(Movement))]
public class PlayerController : MonoBehaviour
{
    public Interacatable focus;


    Camera cam;

    private void Start()
    {
        cam = Camera.main;

    }

    private void Update()
    {
        // lewy przycisk myszy
        if (Input.GetMouseButtonDown(0))

        {
            //create ray
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //if the ray hits
            if (Physics.Raycast(ray, out hit, 100))
            {
                // chceck if we hit an interactable
                Interacatable interactable = hit.collider.GetComponent<Interacatable>();
                // If we did set it as focus
            }
        }
    }
}
