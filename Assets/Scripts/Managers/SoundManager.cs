using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip typewriterSFX;
    public AudioClip gameplayMusic;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySoundByName(string name)
    {
        switch (name)
        {
            case "typewriter":
                PlaySound(typewriterSFX);
                break;
            case "gameplay":
                if (!IsMusicPlaying(gameplayMusic))
                {
                    PlayMusic(gameplayMusic);
                }
                break;
        }
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    private bool IsMusicPlaying(AudioClip clip)
    {
        return audioSource.clip == clip;
    }

    public void PlayMusic(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
