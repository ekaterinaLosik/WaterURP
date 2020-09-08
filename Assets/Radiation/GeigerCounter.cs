using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeigerCounter : MonoBehaviour
{
    public ParticleSystem radiation;
    public AudioSource gcLow; 
    
    // public AudioSource gcMedium; 
    //  public AudioSource gcHigh; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    
    {
                Vector3 pos = radiation.transform.position;

        while (pos.y <= 1.75f)
        {gcLow.Play();}
    }
}
