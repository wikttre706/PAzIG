using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_fox_opener : MonoBehaviour
{
    public GameObject Panel_fox;
    public void OpenPanel_fox()
    {
        if(Panel_fox != null)
        {
            Panel_fox.SetActive(true);
        }

    }
}
