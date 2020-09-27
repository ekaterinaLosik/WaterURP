using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleControllerWebsite : MonoBehaviour
{
    public BubbleSpawnerWebsite Bs;

    public float BubbleSpeed = 0.004f;

    // The smaller the amplitude, the bigger the distance from the center
    public float AmplitudeX = 0.4f;
    public float AmplitudeY = 0.6f;

    public int index;


    IEnumerator WaitAndDestroy(float time) {
        yield return new WaitForSeconds(time);

        Destroy(transform.gameObject);
    }


    private void Update() {
        float posX = Mathf.Cos(Time.time * AmplitudeX + index) * BubbleSpeed;
        float posY = Mathf.Sin(Time.time * AmplitudeY + index * 1.1f) * BubbleSpeed;
        transform.position += new Vector3(posX, posY, 0);

        bool fingerOnScreen = (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButton(0);
        
        if (fingerOnScreen) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // mousePosition also works on the phone
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform.Equals(transform)) {
                Bs.PlayRandomSound();
                StartCoroutine(WaitAndDestroy(0.2f));
            }
        }
    }
}
