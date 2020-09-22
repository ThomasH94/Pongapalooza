using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The purpose of this class is act as a global audio player for any object
/// that wants to play a sound or music.
/// I don't prefer singletons, but in this case I think it's OK
/// </summary>

namespace Pongapalooza
{
    public class AudioPlayer : MonoBehaviour
    {
        [Header("Sound Settings")]
        public AudioSource sfxSource;
        public AudioSource musicSource;
        public float lowPitchRange = 0.90f;
        public float highPitchRange = 1.1f;

        public static AudioPlayer Instance = null;

        public void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else if(Instance != this)
            {
                Destroy(this.gameObject);
            }

            DontDestroyOnLoad(gameObject);
        }

        //We set the audio clip we want to play
        //Randomize the pitch, then PlayOneShot so the sounds don't cancel each other out
        public void PlaySoundEffect(AudioClip clip)
        {
            sfxSource.clip = clip;
            float randomPitch = Random.Range(lowPitchRange, highPitchRange);
            sfxSource.pitch = randomPitch;
            sfxSource.PlayOneShot(clip);        
        }

        //Get the audio clip to play, play the music and cancel out the other music that's playing
        public void PlayMusic(AudioClip clip)
        {
            musicSource.clip = clip;
            musicSource.Play();
        }
    }
}

