using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorsSlider : MonoBehaviour
{
    public Image image;
    public Slider sliR;
    public Slider sliG;
    public Slider sliB;

    Color color;

    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    public void ChangeColor() {
        color = new Color(sliR.value, sliG.value, sliB.value);
        image.color = color;
    }
}
