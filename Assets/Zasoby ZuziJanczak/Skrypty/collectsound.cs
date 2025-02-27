using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectsound : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private AudioClip glassSoundClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        audioSource.clip = glassSoundClip;
        audioSource.Play();
    }
}
