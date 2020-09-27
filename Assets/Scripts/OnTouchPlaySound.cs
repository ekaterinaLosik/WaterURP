using UnityEngine;

public class OnTouchPlaySound : MonoBehaviour {
    void OnMouseDown() {
        transform.parent.gameObject.GetComponent<AudioSource>().Play();
        gameObject.SetActive(false);
    }
}
