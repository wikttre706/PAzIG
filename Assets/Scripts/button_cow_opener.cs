using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_cow_opener : MonoBehaviour
{
    public GameObject Panel_cow;
    public void OpenPanel_cow()
    {
        if(Panel_cow != null)
        {
            Panel_cow.SetActive(true);
        }

    }
}
