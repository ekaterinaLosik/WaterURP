using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanHeightChanger : MonoBehaviour
{
    public ParticleSystem radiation;
    public GameObject oceanPlane;
    public Slider slider;


     public void OnValueChanged(float newValue)
 {
    // audio.volume = newValue;
     oceanPlane.transform.position = new Vector3(0.006f, newValue, -0.023f);
    var emission = radiation.emission;


if (newValue <= 0.16f){
          emission.rateOverTimeMultiplier = 30;

     }
     if (newValue <= 0.17f && newValue > 0.16f){
          emission.rateOverTimeMultiplier = 100;
         // gcLow.Play();

     }
     if (newValue > 0.17f) {
          emission.rateOverTimeMultiplier = 300;

     } }
}
