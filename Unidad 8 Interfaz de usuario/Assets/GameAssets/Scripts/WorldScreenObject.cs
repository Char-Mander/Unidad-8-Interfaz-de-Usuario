using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScreenObject : MonoBehaviour
{
    public bool isWorldSpaceObj;
    bool isGrabed = false;
    // Update is called once per frame
    void Update()
    {
        if (isGrabed) {
            if (!isWorldSpaceObj)
            {
                transform.position = Input.mousePosition;
            }
            else
            {
                Vector3 mouseWorldPosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector3 posiInWorldSpace = new Vector3(mouseWorldPosi.x, mouseWorldPosi.y, transform.position.z);
                transform.position = posiInWorldSpace;
            }
        }

        if (Input.GetMouseButtonDown(0)) {
            if (isGrabed)
            {
                isGrabed = false;
            }else {
                Collider2D col2 = DetectClick(isWorldSpaceObj);
                if (col2 != null)
                {
                    print(col2.gameObject.name);
                    isGrabed = true;
                }
            }
        }

    }

    Collider2D DetectClick(bool worldObj) {
        Collider2D col;
        if (worldObj)
        {
            Vector3 mouseWorldPosi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 posiInWorldSpace = new Vector3(mouseWorldPosi.x, mouseWorldPosi.y, transform.position.z);
            col = Physics2D.OverlapPoint(posiInWorldSpace);
        }else {
            col = Physics2D.OverlapPoint(Input.mousePosition);
        }
        return col;
    }

}
