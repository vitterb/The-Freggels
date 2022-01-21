using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiomanager : MonoBehaviour
{
    public AudioSource BackgroundMusic;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMusic ( AudioClip music)
    {
        if (BackgroundMusic.clip.name == music.name)
            return;
        BackgroundMusic.Stop();
        BackgroundMusic.clip = music;
        BackgroundMusic.Play(); 
    }
}

// code by Gamesplusjames
