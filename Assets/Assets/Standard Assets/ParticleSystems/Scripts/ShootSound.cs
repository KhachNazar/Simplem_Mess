using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ShootSound : MonoBehaviour {

	void Update ()
    {
	    if(Input.GetButtonDown("Fire1"))
        {
            PlayShootSound();
        }

        if (Input.GetButtonUp("Fire1"))
        {
            StopShootSound();
        }
    }

    public void PlayShootSound()
    {
        AudioSource shootSound = GetComponent<AudioSource>();
        shootSound.Play();
    }

    public void StopShootSound()
    {
        AudioSource shootSound = GetComponent<AudioSource>();
        shootSound.Stop();
    }
}
