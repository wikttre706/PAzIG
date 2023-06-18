using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;
using System.Threading.Tasks;

public class Check : MonoBehaviour
{
    public GameObject Panel_check;
    public bool inCooldown = false;

    public async void OpenPanel_check()
    {
        //if the lock is not enabled
        if (Panel_check !=null)
        {
            Panel_check.SetActive(true);
            await Task.Delay(2000); //86400000
            Panel_check.SetActive(false);
            inCooldown = false;
        }

    }

}

