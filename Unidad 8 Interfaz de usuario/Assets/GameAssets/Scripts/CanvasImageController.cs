using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasImageController : MonoBehaviour
{
    public Image circleTimeImg;
    public Image barTimeImg;

    TimeController tc;

    private void Start()
    {
        tc = FindObjectOfType<TimeController>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimeBars();
    }

    void UpdateTimeBars() {
        float fillValue = tc.currentTime / tc.maxTime;
        circleTimeImg.fillAmount = fillValue;
        barTimeImg.fillAmount = fillValue;
    }

}
