using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Text cambiosEscenaTxt;
    public Text coinsAmount;

    // Start is called before the first frame update
    void Start()
    {
        cambiosEscenaTxt.text = GameManager.instance.sceneJumps.ToString();
        coinsAmount.text = GameManager.instance.coins.ToString();
    }

    public void BtnChangeScene( string sceneName) {
        GameManager.instance.sceneC.ChangeScene(sceneName);
    }

    public void BtnGetCoin() {
        GameManager.instance.coins++;
        coinsAmount.text = GameManager.instance.coins.ToString();
        GameManager.instance.dataM.SaveData();
    }

}
