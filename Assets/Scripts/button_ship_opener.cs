using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_ship_opener : MonoBehaviour
{
    public GameObject Panel_ship;
    public void OpenPanel_ship()
    {
        if(Panel_ship != null)
        {
            Panel_ship.SetActive(true);

        }

    }
}
