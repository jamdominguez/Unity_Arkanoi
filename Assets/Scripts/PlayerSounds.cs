using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour {
    public AudioSource ballSound;
    public AudioSource pointSound;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Block")) pointSound.Play();
        else ballSound.Play();
    }
}
