using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadingIn : MonoBehaviour {

    public bool triggered;

    [SerializeField]
    public float fadeinDuration;

    private Color myColor;
    private float t = 0;
    private float value;

    [SerializeField]
    Gradient myGradient;

    // Use this for initialization
    public void Start()
    {
        myColor = this.GetComponent<MeshRenderer>().material.color;
        myColor.a = 0;
    }

    // Update is called once per frame
    public void Update()
    {
        if (triggered)
        {
            value = Mathf.Lerp(0f, 1f, t);
            t += Time.deltaTime / fadeinDuration;
            this.GetComponent<MeshRenderer>().material.color = myGradient.Evaluate(value);
            myColor = this.GetComponent<MeshRenderer>().material.color;
            myColor.a = value;
            this.GetComponent<MeshRenderer>().material.color = myColor;
        }
    }

}
