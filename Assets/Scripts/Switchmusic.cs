using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchmusic : MonoBehaviour
{
    public AudioClip newTrack;
    private Audiomanager am;
    void Start()
    {
        am = FindObjectOfType<Audiomanager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (newTrack != null)
        {
            am.ChangeMusic(newTrack);
        }

    }
    //    Sorrow by Alexander Nakarada | https://www.serpentsoundstudios.com
    //Music promoted by https://www.chosic.com/free-music/all/
    //Creative Commons CC BY 4.0
    //https://creativecommons.org/licenses/by/4.0/

}
