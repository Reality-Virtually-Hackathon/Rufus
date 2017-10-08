using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startaudio : MonoBehaviour {

    public float starttime;
    private bool playonce = false;

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<AudioSource>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!playonce)
        {
            if (Time.timeSinceLevelLoad > starttime)
            {
                this.gameObject.GetComponent<AudioSource>().enabled = true;
                this.gameObject.GetComponent<AudioSource>().Stop();
                this.gameObject.GetComponent<AudioSource>().Play();
                playonce = true;
            }
        }
	}
}
