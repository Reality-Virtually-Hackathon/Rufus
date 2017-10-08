using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainTransition : MonoBehaviour {

    public float starttime;
    public float endtime;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Time.time < starttime)
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        } else if ((Time.time >= starttime) && (Time.time < endtime))
        {
            this.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
