using UnityEngine.Audio;
using UnityEngine;
using System;


public class AudioManagement : MonoBehaviour
{
    public Sound[] music;

    public static AudioManagement ins;


    public void Awake()
    {
       if (ins == null)
        { ins = this; }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach (Sound s in music)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }

    }
    public void Play(String name)
    {
        Sound s = Array.Find(music, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("NO Such audio exists!!");
            return;
        }
        s.source.Play();
    }
    public void Start()
    {
        Play("theme");
    }

}
