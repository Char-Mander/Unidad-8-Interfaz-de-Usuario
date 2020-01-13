using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public Item scrOItem;

    public Image itemImage;
    public Text itemName;
    public Text itemDesc;

    // Start is called before the first frame update
    void Start()
    {
        if (scrOItem != null)
        {
            itemImage.sprite = scrOItem.itemImage;
            itemName.text = scrOItem.itemName;
            itemDesc.text = scrOItem.itemDesc;
        }
    }

    public void ButtonDown() {
        print("He utilizado el objeto " + scrOItem.itemName);
        Destroy(this.gameObject);
    }

}
