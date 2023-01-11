//to make the script work just add it to any gameobject inside the scene and attach your main light source in the opening.
//you can adjust how fast the day is passing by chaning the "timePassing" number, the bigger the number the faster the day goes.
//hope it helped you ;)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public GameObject mainLight;

    public float timePassing = 0.1f;

    public float time;

    private void Update()
    {
        time += timePassing * Time.deltaTime;
        mainLight.transform.rotation = Quaternion.Euler(time, 0, 0);
    }
}
