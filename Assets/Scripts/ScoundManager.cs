using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoundManager : MonoBehaviour
{

    public AudioClip laser;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
        audio.clip = laser;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.Play();
    }
}
