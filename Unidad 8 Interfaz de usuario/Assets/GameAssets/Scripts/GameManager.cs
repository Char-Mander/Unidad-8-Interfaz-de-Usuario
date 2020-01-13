using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public static GameManager instance = null;
    [HideInInspector]
    public SceneController sceneC;
    [HideInInspector]
    public DataManager dataM;
    [HideInInspector]
    public MouseCursorController mouseCursorC;

    public int sceneJumps{get;set;}
    public int coins { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        Init();
    }

    void Init() {
        sceneJumps = 0;
        sceneC = GetComponent<SceneController>();
        dataM = GetComponent<DataManager>();
        GetComponent<DataManager>().LoadData();
        mouseCursorC = GetComponent<MouseCursorController>();
        mouseCursorC.ChangeCursor(mouseCursorC.normalCursor);
    }

}
