using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections;
using System.Linq; // Use Linq
using System;

public class StoryManager : MonoBehaviour {

    [SerializeField]
    public List<TriggerEvent> eventList;

    private int currenteventidx = 0;

    // Use this for initialization
    void Start () {
        
        //eventList = new List<TriggerEvent>();

        if(eventList != null)
        {
            List<TriggerEvent> sortedEventlist = eventList.OrderBy(i => i.triggerTime).ToList<TriggerEvent>(); //Ascending
            //List<TriggerEvent> sortedEventlist = eventList.OrderByDescending(i => i.triggerTime); // Descending Order
            //List<TriggerEvent> sortedEventlist = eventList.Sort((s1, s2) => (float) s1.triggerTime.CompareTo((float) s2.triggerTime));
            eventList = sortedEventlist;
        }

        foreach (var e in eventList)
        {
            Debug.Log(e.triggerTime);
        }
    }
	
	// Update is called once per frame
	void Update () {

        if(currenteventidx >= eventList.Count)
        {
            // Do nothing
        } else
        {
            if (Time.time > eventList[currenteventidx].triggerTime)
            {
                //Type t = Type.GetType(eventList[currenteventidx].triggerScriptName); --> Cannot do that unfortunately --> use switch statement instead

                //Execute Trigger
                GameObject go = eventList[currenteventidx].myGameObject;
                string myString = eventList[currenteventidx].triggerScriptName;

                switch (myString)
                {
                    case "ChangeMaterialColor":
                        go.GetComponent<ChangeMaterialColor>().triggered = true;
                        break;
                    case "Change Skybox":
                        go.GetComponent<ChangeMaterialColor>().triggered = true;
                        break;
                    case "FadingIn":
                        go.GetComponent<FadingIn>().triggered = true;
                        break;
                    case "Fade Out":
                        go.GetComponent<FadeOut>().triggered = true;
                        break;
                    default:
                        break;

                        // Extend switch ...
                }
                //eventList[currenteventidx].myGameObject.GetComponent<string>();
                //Move to next trigger event
                if (currenteventidx < eventList.Count)
                {
                    currenteventidx += 1;
                }
            }
        }
 
       

    }
}
