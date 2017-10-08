using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

    //public GameObject obj;
    public bool triggered;

    [SerializeField]
    public float fadeoutDuration;

    private Color myColor;
    private float t = 0;
    private float value;

    [SerializeField]
    Gradient myGradient;

    // Use this for initialization
    void Start () {
        myColor = this.GetComponent<MeshRenderer>().material.color;
        myColor.a = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (triggered)
        {
            value = Mathf.Lerp(0f, 1f, t);
            t += Time.deltaTime / fadeoutDuration;
            this.GetComponent<MeshRenderer>().material.color = myGradient.Evaluate(value);
            myColor = this.GetComponent<MeshRenderer>().material.color;
            myColor.a = 1 - value;
            this.GetComponent<MeshRenderer>().material.color = myColor;
        }
    }
}
