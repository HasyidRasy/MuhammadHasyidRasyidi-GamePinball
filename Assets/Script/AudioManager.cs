using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{   
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioBumperSource;
    public GameObject sfxAudioSwitchOnSource;
    public GameObject sfxAudioSwitchOffSource;

    private void Start()
	{
		PlayBGM();
	}
	
	private void PlayBGM() 
    {
        bgmAudioSource.Play();
    }

	public void PlaySFXBumper(Vector3 spawnPosition) 
    {
        GameObject.Instantiate(sfxAudioBumperSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitchOn(Vector3 spawnPosition) 
    {
        GameObject.Instantiate(sfxAudioSwitchOnSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitchOff(Vector3 spawnPosition) 
    {
        GameObject.Instantiate(sfxAudioSwitchOffSource, spawnPosition, Quaternion.identity);
    }
}
