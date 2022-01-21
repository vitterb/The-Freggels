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
        BackgroundMusic.Stop();
        BackgroundMusic.clip = music;
        BackgroundMusic.Play(); 
    }
}
