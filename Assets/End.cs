using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour {

	
	public Text endText;
	
	public String regular = " ";

	public AudioSource music;

	public AudioSource endMusic;
	
	void Start () 
	{
		
	}
	

	void Update () 
	{
		
	}

	private void OnCollisionEnter(Collision other)
	{
		regular = "THE BALL WENT IN THE BUCKET! WOW!";
		endText.text = regular;
		music.Stop();
		endMusic.Play();
	}
}
