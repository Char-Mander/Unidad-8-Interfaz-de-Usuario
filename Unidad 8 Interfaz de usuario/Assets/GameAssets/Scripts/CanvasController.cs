using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Text tituloMain;
    public Text countDownText;
    public float nume = 10;

    // Start is called before the first frame update
    void Start()
    {
        tituloMain.text = "TEST TITLE";
        countDownText.text = "<color='white'>Tiempo restante: </color><color='red'>" + nume.ToString() + "</color>";
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown() {
        yield return new WaitForSeconds(1);
        nume--;
        countDownText.text = "<color='white'>Tiempo restante: </color><color='red'>" + nume.ToString() + "</color>";
        if (nume>0)
        StartCoroutine(CountDown());
    }

    public void BtnTest1() {
        print("Botón pulsado");
    }

}
