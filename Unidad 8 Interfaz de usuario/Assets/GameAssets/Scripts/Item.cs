using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/new item", order = 1)]
public class Item : ScriptableObject
{
    public Sprite itemImage;
    public string itemName;
    public string itemDesc;

}
