using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxBumperSource;
	public GameObject vfxSwitchSource;

	public void PlayVFXBumper(Vector3 spawnPosition)
	{
		GameObject.Instantiate(vfxBumperSource, spawnPosition, Quaternion.identity);
	}

	public void PlayVFXSwitch(Vector3 spawnPosition)
	{
		GameObject.Instantiate(vfxSwitchSource, spawnPosition, Quaternion.identity);
	}
}
