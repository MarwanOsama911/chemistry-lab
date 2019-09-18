using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundfireplay : MonoBehaviour {

    public AudioClip audiofile;
    public AudioSource audiosource;

    public void plays()
    {
        audiosource.PlayOneShot(audiofile);
    }

    public void stops()
    {
        audiosource.Stop();
    }
}
