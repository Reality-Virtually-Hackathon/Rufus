using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTintColor : MonoBehaviour {

    public bool triggered;
    public float fadeinstarttime;
    public float fadeinduration;
    public float fadeoutstarttime;
    public float fadeoutduration;

    private float t = 0;
    private Color myColor;
    private float value;
    private Renderer myRenderer;

    [SerializeField]
    Gradient fadeinGradient;
    [SerializeField]
    Gradient fadeoutGradient;

    // Use this for initialization
    void Start () {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update () {
        if (triggered)
        {
            if(Time.time > fadeinstarttime && Time.time < fadeinstarttime + fadeinduration)
            {
                value = Mathf.Lerp(0f, 1f, t);
                t += Time.deltaTime / fadeinduration;
                myColor = fadeinGradient.Evaluate(value);
                //myRenderer.material.shader = Shader.Find("Standard");
                myRenderer.material.SetColor("_TintColor", myColor);
                //gameObject.GetComponent<Material>().SetColor("_Color", myColor);
            } else if(Time.time > fadeoutstarttime && Time.time < fadeoutstarttime + fadeoutduration)
            {
                value = Mathf.Lerp(0f, 1f, t);
                t += Time.deltaTime / fadeoutduration;
                myColor = fadeoutGradient.Evaluate(value);
                //myRenderer.material.shader = Shader.Find("Standard");
                myRenderer.material.SetColor("_TintColor", myColor);
                //gameObject.GetComponent<Material>().SetColor("_Color", myColor);
            } else
            {
                t = 0;
            }

        }
    }
}
