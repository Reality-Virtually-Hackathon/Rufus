using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionPicture : MonoBehaviour {

    //public Texture myTexture;

    // Use this for initialization
    void Start () {
        //myTexture = (Texture) Resources.Load("Start Scence");
        StartCoroutine("WaitFor7Seconds");
    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator WaitFor7Seconds()
    {
        print(Time.time);
        yield return new WaitForSeconds(7);
        print(Time.time);
        SceneManager.LoadScene("Rufus_v1_Vive",LoadSceneMode.Single);
    }


    //private void OnGUI()
    //{
    //    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), myTexture, ScaleMode.StretchToFill);   //or the brackets if it's only one line
    //    GUI.color = Color.black;
    //}

}
