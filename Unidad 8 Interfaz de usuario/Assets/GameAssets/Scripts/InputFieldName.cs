using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldName : MonoBehaviour
{
    public InputField iNametxt;
    public Text nameTxt;

    public void ActualiceName() {
        nameTxt.text = iNametxt.text;
    }

    public void ConfirmName() {
        if (iNametxt.text != "") {
            nameTxt.color = Color.blue;
            nameTxt.text = iNametxt.text;
            iNametxt.interactable = false;
        }
    }

}
