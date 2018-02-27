using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
	public Camera camera1;
	public Camera camera2;
	public Camera camera3;
	public Camera camera4;

	public AudioSource music;

	public GameObject holder;

	// Use this for initialization
	void Start ()
	{
		camera1.enabled = true;
		camera2.enabled = false;
		camera3.enabled = false;
		camera4.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Destroy(holder);
			music.Play();
		}
		if (Input.GetKeyUp(KeyCode.Alpha1))
		{
			camera1.enabled = true;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = false;
		}

		if (Input.GetKeyUp(KeyCode.Alpha2))
		{
			camera1.enabled = false;
			camera2.enabled = true;
			camera3.enabled = false;
			camera4.enabled = false;
		}

		if (Input.GetKeyUp(KeyCode.Alpha3))
		{
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = true;
			camera4.enabled = false;
		}
		if (Input.GetKeyUp(KeyCode.Alpha4))
		{
			camera1.enabled = false;
			camera2.enabled = false;
			camera3.enabled = false;
			camera4.enabled = true;
		}
	}
	
	
}
