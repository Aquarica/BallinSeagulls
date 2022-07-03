using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honk : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // plays on a detected collision
    void OnTriggerEnter(Collider collider) 
    {
        Debug.Log("Play sound");
        source.Play();
    }
}
