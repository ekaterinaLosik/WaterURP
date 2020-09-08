using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class badWeather : MonoBehaviour
{
    public ParticleSystem radiation;
    public Material waves;
    public float waveHeight = 1;
    public bool enableBadWeather = false;
    public Toggle toggle;
    public Color colorGWTop = new Color(0.5986117f, 0.6739377f, 0.7169812f,0);
    public Color colorGWBot = new Color(0.4300463f, 0.5845828f, 0.6037736f,0);
    public AudioSource gcHigh;


    // Start is called before the first frame update
    void Start()
    {
        
        waves.SetFloat("Vector1_F8D9205E", waveHeight);

    }

    // Update is called once per frame
    void Update()
    {
       if (toggle.isOn && gcHigh.isPlaying ==false)
        {
            waveHeight = 2.5f;
            waves.SetFloat("Vector1_F8D9205E", waveHeight);
            waves.SetFloat("Vector1_C8CD7BB7", 0.25f);
            waves.SetColor("Color_31F2026D", Color.black);
            waves.SetColor("Color_C8989E96", Color.black);
            var emission = radiation.emission;
          //  emission.rateOverTimeMultiplier = 300;
            emission.SetBursts(new ParticleSystem.Burst[]{ new ParticleSystem.Burst(0.01f, 10, 10, 0, 0.01f)});
            gcHigh.Play();
        }
         if (!toggle.isOn && gcHigh.isPlaying == true)
        {
            waveHeight = 1;
            waves.SetFloat("Vector1_F8D9205E", waveHeight);
            waves.SetFloat("Vector1_C8CD7BB7", 0.1f);
            waves.SetColor("Color_31F2026D",  colorGWTop);
            waves.SetColor("Color_C8989E96",  colorGWBot);
           var emission = radiation.emission;
            emission.SetBursts(new ParticleSystem.Burst[]{ new ParticleSystem.Burst(0, 0)});
            gcHigh.Stop();
        }
        
    }
}
