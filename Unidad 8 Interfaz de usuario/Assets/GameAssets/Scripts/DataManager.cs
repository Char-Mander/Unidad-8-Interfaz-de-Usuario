using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class DataManager : MonoBehaviour
{
    public const string coinsKey = "Coins";

	public void LoadData() {
        if (PlayerPrefs.HasKey(coinsKey) == true)
        {
            GameManager.instance.coins = PlayerPrefs.GetInt(coinsKey);
        }
    }

    public void SaveData() {
       PlayerPrefs.SetInt(coinsKey, GameManager.instance.coins);
    }

    [MenuItem("Utilidades/Reset Data")]
    public static void RestartData() {
        PlayerPrefs.DeleteAll();
    }

}
