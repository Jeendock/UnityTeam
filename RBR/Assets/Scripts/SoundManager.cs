using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource music;
    public AudioSource Sfx;
    static AudioSource instance1;
    static AudioSource instance2;

    //private void Awake()
    //{
    //if (instance1 != null)
    //{
    //    Destroy(music);
    //    return;
    //}
    //instance1 = music;
    //DontDestroyOnLoad(music);

    //if (instance2 != null)
    //{
    //    Destroy(Sfx);
    //    return;
    //}
    //instance2 = Sfx;
    //DontDestroyOnLoad(Sfx);
    //}

    public void SetMusicVolume(float value)
    {
        music.volume = value;
    }

    public void SetSFXVolume(float value)
    {
        Sfx.volume = value;
    }

    public void SetMuteToggle(Toggle toggle)
    {
        if (toggle.isOn)
        {
            music.mute = true;
            Sfx.mute = true;
        }
        else
        {
            music.mute = false;
            Sfx.mute = false;
        }
    }

    public void UseSFX()
    {
        Sfx.Play();
    }
}