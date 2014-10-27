﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WalkingSFX : MonoBehaviour {

	public Camera myCamera;

	private float stepTimer = 0.0f;
	public float timeTillNextStep;

	//Lists of audioclips
	public List<AudioClip> stepSource;


	void Start()
	{


	}

	void FixedUpdate ()
	{
		stepTimer += Time.deltaTime;


		if(Input.GetAxis("Horizontal")!= 0 || Input.GetAxis("Vertical") != 0)
		{

			if (myCamera.enabled == true && stepTimer >= timeTillNextStep)
			{
				GetRandomSound (stepSource);
			}

		}
	}


	void GetRandomSound (List<AudioClip> randomClip)
	{
		int j = Random.Range(0, (randomClip.Count - 1));
		audio.PlayOneShot (randomClip[j]);
		stepTimer = 0;
	}

}
