using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3Manager : MonoBehaviour {

    public float spawntime;
    public GameObject Go;
    private bool respawned=false;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Go = this.transform.GetChild(i).gameObject;
            Go.GetComponent<MeshRenderer>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update () {

        if (!respawned)
        {
            if (Time.timeSinceLevelLoad > spawntime)
            {
                StartCoroutine("Example");
                respawned = true;
            }
        }

	}


    IEnumerator Example()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Go = this.transform.GetChild(i).gameObject;
            print(Time.time);
            yield return new WaitForSeconds(0.15f); //deltaspawntime
            print(Time.time);
            Go.GetComponent<MeshRenderer>().enabled = true;
        }

    }
}
