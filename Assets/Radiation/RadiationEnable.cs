using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RadiationEnable : MonoBehaviour

{

public ParticleSystem radiation;

    public AudioSource gcLow;

public Toggle toggle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (toggle.isOn && gcLow.isPlaying == false)
        {
            radiation.Play();
            gcLow.Play();

        }
         if (!toggle.isOn && gcLow.isPlaying == true)
        {
          radiation.Stop();
          gcLow.Stop();

        }
        
    }
}
