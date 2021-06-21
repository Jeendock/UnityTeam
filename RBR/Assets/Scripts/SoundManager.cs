using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource music;

    private void Awake()
    {
        DontDestroyOnLoad(music);
    }

    public void SetMusicVolume(float value)
    {
        music.volume = value;
    }

    public void SetMuteToggle(Toggle toggle)
    {
        if (toggle.isOn)
        {
            music.mute = true;
        }
        else
        {
            music.mute = false;
        }
    }
}