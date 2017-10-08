using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freefall : MonoBehaviour {

    public float falltime; // start time that you fall

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	

        if (Time.timeSinceLevelLoad > falltime)
        {
            this.gameObject.SetActive(false);
        }

        //if(Time.timeSinceLevelLoad < 10 + falltime && Time.timeSinceLevelLoad > falltime)
        //{
        //    go.transform.position.Set(go.transform.position.x, go.transform.position.x + 0.25f, go.transform.position.z);
        //} else if (Time.timeSinceLevelLoad > 10 + falltime)
        //{
        //    go.SetActive(false);
        //}
	}
}
