using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItemBtn : MonoBehaviour
{
    Object[] items;

    public GameObject ItemButtonPref;
    public Transform contentPanel;

    // Start is called before the first frame update
    void Start()
    {
        items = Resources.LoadAll("ScrItems", typeof(Item)) ;
    }

    public void CreateNewRandomItem() {
        GameObject go = Instantiate(ItemButtonPref, contentPanel);
        go.GetComponent<ItemButton>().scrOItem = items[Random.Range(0, items.Length)] as Item;
    }

}
