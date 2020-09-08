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
     oceanPlane.transform.position = new Vector3(0.07f, newValue, -0.23f);
    var emission = radiation.emission;
if (newValue <= 1.7f){
          emission.rateOverTimeMultiplier = 20;

     }
     if (newValue <= 1.85f && newValue > 1.7f){
          emission.rateOverTimeMultiplier = 100;
         // gcLow.Play();

     }
     if (newValue > 1.85f) {
          emission.rateOverTimeMultiplier = 300;

     } }
}
