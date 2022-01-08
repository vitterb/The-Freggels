using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    public static TimeController instance;
    public Text timecounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    private void Start()
    {
        timecounter.text = "Time: 00:00:00";
        //StartTime = Time.time;
        elapsedTime = 0f;    
        timerGoing = true;

        StartCoroutine(UpdateTimer());
    }
    private void endTimer()
    {
        timerGoing = false;
    }
    // Update is called once per frame
    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss'.'ff");
            timecounter.text = timePlayingStr;

            yield return null;
        }
    }
}
