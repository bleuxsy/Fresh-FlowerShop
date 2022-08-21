using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSFX : MonoBehaviour
{
    public AudioSource audioData;
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }
    void Update() { 
        if(Input.GetMouseButtonDown(0))
            audioData.Play();
    }
}
