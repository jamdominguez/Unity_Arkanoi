using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunSounds : MonoBehaviour {
    public AudioSource musicSource;
    public AudioClip completed;
    public AudioClip gameOver;
    public AudioSource failSource;

    public void PlayCompleted() {
        musicSource.pitch = 1f;
        PlayAudioClip(completed);
    }

    public void PlayGameOver() {
        musicSource.pitch = 1f;
        PlayAudioClip(gameOver);
    }

    public void PlayFail() {
        failSource.Play();
    }

    public void Faster() {
        musicSource.pitch = 1.2f;
    }

    void PlayAudioClip(AudioClip clip) {
        musicSource.clip = clip;
        musicSource.loop = false;
        musicSource.Play();
    }

}
