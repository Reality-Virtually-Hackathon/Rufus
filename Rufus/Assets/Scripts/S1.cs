using UnityEngine;
using System.Collections;
public class S1 : MonoBehaviour
{
    public bool playAnim;
    public Animation move;

    void Start()
    {

        playAnim = true;
    }
    void Update()
    {

        if (playAnim)
        {
            playAnim = false;
            StartCoroutine(Wait());

        }
    }//update ends
    public IEnumerator Wait()
    {

        yield return new WaitForSeconds(5);
        move.Play("run");
    }
}