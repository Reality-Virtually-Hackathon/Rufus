using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour {

    public bool triggered;

    [SerializeField]
    public float animationDuration;
    private float t = 0;
    private Color myColor;
    private float value;
    private Renderer myRenderer;

    [SerializeField]
    Gradient myGradient;


    // Use this for initialization
    void Start () {
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update () {
        if (triggered)
        {
            value = Mathf.Lerp(0f, 1f, t);
            t += Time.deltaTime / animationDuration;
            myColor = myGradient.Evaluate(value);
            myRenderer.material.shader = Shader.Find("Standard");
            myRenderer.material.SetColor("_Color", myColor);
            //gameObject.GetComponent<Material>().SetColor("_Color", myColor);

        }
    }
}
