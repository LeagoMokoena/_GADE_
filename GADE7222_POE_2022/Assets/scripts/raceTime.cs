using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;

public class raceTime : MonoBehaviour
{
    float curTime = 0f;
    float starTime = 30f;

    [SerializeField] Text count;
    [SerializeField] Text lose;

    // Start is called before the first frame update
    void Start()
    {
        curTime = starTime;
    }

    // Update is called once per frame
    void Update()
    {
        curTime -= 1 * Time.deltaTime;
        count.text = curTime.ToString("0");

        if(curTime <= 0)
        {
            curTime = 0;
            lose.enabled = true;
            lose.text = "You lose";
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        curTime += 5;
    }

}
