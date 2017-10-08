using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeinLight : MonoBehaviour {

    Light mylight;
    public float timetoenablelight;
    public float riseduration;

    private float t = 0;

    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<Light>().intensity = 0;
    }

    // Update is called once per frame
    void Update () {

        if (Time.timeSinceLevelLoad > timetoenablelight && t <= 1)
        {
            t = (Time.timeSinceLevelLoad - timetoenablelight) / riseduration;
            this.gameObject.GetComponent<Light>().intensity = t;
        }

    }
}
