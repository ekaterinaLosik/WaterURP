
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawnerWebsite : MonoBehaviour
{
    public Material[] AllMats;
    public AudioClip[] AllSounds;
    public GameObject Bubble;

    public int TimeBetweenBubbles;
    public int MaxBubbleAmount = 10;

    public float BubbleMinSize = 0.3f;
    public float BubbleMaxSize = 0.6f;

    public bool SpawnBubbles;

    private AudioSource AudioSource;

    private float t;

    private int bubbleIndex;

    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        t += Time.deltaTime;

        if(t > TimeBetweenBubbles && transform.childCount < MaxBubbleAmount && SpawnBubbles) {
            t = 0;
            
            GameObject bubble = Instantiate(Bubble, transform);
            int matId = Random.Range(0, AllMats.Length);
            
            float size = Random.Range(BubbleMinSize, BubbleMaxSize);
            bubble.transform.localScale = new Vector3(size, size, size);
            bubble.GetComponent<Renderer>().material = AllMats[matId];
            BubbleControllerWebsite bc = bubble.GetComponent<BubbleControllerWebsite>();
            bc.index = bubbleIndex;
            bc.Bs = this;
            bubbleIndex++;

        }
    }

    public void PlayRandomSound() {
        int soundID = Random.Range(0, AllSounds.Length);
        AudioSource.clip = AllSounds[soundID];
        AudioSource.Play();
    }

    public void RemoveAllBubbles() {
        bubbleIndex = 0;
        foreach (Transform child in transform) {
            Destroy(child.gameObject);
        }
    }
}
