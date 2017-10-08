using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkybox : MonoBehaviour {

    public bool triggered;
    public float start_time; // Start Time
    public float end_time_1;

    private float t=0;
    private Skybox mySkybox;
    private Color myColor;
    private float value;

    [SerializeField]
    Gradient myGradient;

	// Use this for initialization
	void Start () {
        mySkybox = this.GetComponent<Skybox>();
        mySkybox.material.SetColor("_SkyColor1", Color.white);
        mySkybox.material.SetColor("_SkyColor2", Color.white);
    }

    // Update is called once per frame
    void Update () {
        if((Time.timeSinceLevelLoad > start_time) && (Time.timeSinceLevelLoad < end_time_1))
        {
            if (triggered)
            {
                value = Mathf.Lerp(0f, 1f, t);
                t += Time.deltaTime / (end_time_1 - start_time);
                myColor = myGradient.Evaluate(value);
                mySkybox.material.SetColor("_SkyColor1", myColor);
                mySkybox.material.SetColor("_SkyColor2", myColor);
            }
        } 
    }
}
