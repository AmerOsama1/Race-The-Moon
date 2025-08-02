using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    public float Timer;
    public List<GameObject> planes;
   static public float newSpeed =-30;
    void Start()
    {
        Time.timeScale = 1;

    }

    void Update()
    {

        Timer += Time.deltaTime;
        GameObject bor  = GameObject.FindGameObjectWithTag("bor");
        GameObject[] foundPlanes = GameObject.FindGameObjectsWithTag("plan");
        planes = new List<GameObject>(foundPlanes);

        bor.GetComponent<OnlyForward>().speed = newSpeed;

        foreach (GameObject sss in planes)
        {
            OnlyForward forwardScript = sss.GetComponent<OnlyForward>();
            if (forwardScript != null)
            {
                forwardScript.speed = newSpeed;
            }

        }

        if (Timer > 20f)

        {
            Score.IncScore += 5;
            newSpeed -= 10f;
               Timer = 0; // prevent repeated execution
         }
        
        
    }

}