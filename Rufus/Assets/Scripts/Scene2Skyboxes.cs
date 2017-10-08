using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Skyboxes : MonoBehaviour {

    public bool triggered;
    public float start_time; // Start Time of process replacing the skybox material [process: gradient -> replace]
    public float up_slope_time; // time used for going into the gradient color
    public float start_time_2; // Start Time of replacing the skybox material
    public float down_slope_time; // time used for going into the gradient color

    public Material newSkybox;

    private float t = 0;
    private Color myColor;
    private float value;
    private Material bufferMaterial;


    [SerializeField]
    Gradient upGradient;
    [SerializeField]
    Gradient downGradient;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
        if (triggered)
        {
            if ((Time.time > start_time) && (start_time+up_slope_time>Time.time))
            {
                value = Mathf.Lerp(0f, 1f, t);
                t += Time.deltaTime/up_slope_time;
                myColor = upGradient.Evaluate(value);
                this.GetComponent<Skybox>().material.SetColor("_SkyColor2", myColor); // only changing the Horizon color
            } else if (Time.time > start_time_2){
                value = Mathf.Lerp(0f, 1f, t);
                t += Time.deltaTime / down_slope_time;
                myColor = downGradient.Evaluate(value);
                this.GetComponent<Skybox>().material.SetColor("_SkyColor2", myColor); // only changing the Horizon color
            } else
            {
                t = 0;
            }



            //else if ((start_time + up_slope_time > Time.time) && (Time.time < start_time_2))
            //{
            //    this.GetComponent<Skybox>().material = (Material)Resources.Load("DannySkybox", typeof(Material));
            //}
        }

    }
}
