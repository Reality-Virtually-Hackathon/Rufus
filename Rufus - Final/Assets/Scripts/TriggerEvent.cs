using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct TriggerEvent {

    public GameObject myGameObject; // GameObject Name
    public string triggerScriptName; // Script Name to be executed
    public float triggerTime;

	public TriggerEvent(GameObject go, string ts, float tt)
    {
        myGameObject = go;
        triggerScriptName = ts;
        triggerTime = tt;
    }
    
}
