using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public float maxTime =10;
    public float timeSpeed =1;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        StartCoroutine(CountDown());
    }

    
    IEnumerator CountDown() {
        yield return new WaitForSeconds(timeSpeed);
        currentTime -= timeSpeed;
        if (currentTime > 0)
        {
            StartCoroutine(CountDown());
        }
        else {
            currentTime = 0;
        }
        
    }

}
