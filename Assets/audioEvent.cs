using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioEvent : MonoBehaviour {
    public AudioClip ella;
    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Play()
    {
        audioSource.PlayOneShot(ella);
    }
}
