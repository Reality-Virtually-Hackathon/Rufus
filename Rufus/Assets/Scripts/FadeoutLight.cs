using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeoutLight : MonoBehaviour
{
    Light mylight;
    public float timetodisablelight;
    public float decayduration;

    private float t = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.timeSinceLevelLoad > timetodisablelight && t <= 1)
        {
            t = (Time.timeSinceLevelLoad - timetodisablelight) / decayduration;
            this.gameObject.GetComponent<Light>().intensity = 1-t;
        }

    }
}
