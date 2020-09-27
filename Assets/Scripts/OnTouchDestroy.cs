using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchDestroy : MonoBehaviour
{
	private AudioSource audioSource;
	

	// Use this for initialization
	void Start () {
		audioSource = GameObject.FindGameObjectWithTag("Sound").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
	    audioSource.Play();
        Destroy(gameObject);
    }
}
