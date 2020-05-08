using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The behavior to make the timer work
public class TimerBehavior : MonoBehaviour
{
    [SerializeField]
    Text timerText;

    public float time = 0.0f;
    public int displayTime = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        displayTime = (int)time;

        timerText.text = displayTime.ToString();
    }
}
