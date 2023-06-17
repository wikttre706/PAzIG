using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    
    public int score1;
    public int score2;
    public int score3;
    public int score4;
    public int score5;
    public int score6;
    public int score7;
    public int score8;
    public int score9;
    public int score10;

    public TextMeshProUGUI score1Text;
    public TextMeshProUGUI score2Text;
    public TextMeshProUGUI score3Text;
    public TextMeshProUGUI score4Text;
    public TextMeshProUGUI score5Text;
    public TextMeshProUGUI score6Text;
    public TextMeshProUGUI score7Text;
    public TextMeshProUGUI score8Text;
    public TextMeshProUGUI score9Text;
    public TextMeshProUGUI score10Text;

    void Update()
    {
        score1Text.text = score1.ToString();
        score2Text.text = score2.ToString();
        score3Text.text = score3.ToString();
        score4Text.text = score4.ToString();
        score5Text.text = score5.ToString();
        score6Text.text = score6.ToString();
        score7Text.text = score7.ToString();
        score8Text.text = score8.ToString();
        score9Text.text = score9.ToString();
        score10Text.text = score10.ToString();
    }

    public void AddPoint1()
    {
        score1++;
    }
    public void AddPoint2()
    {
        score2++;
    }
    public void AddPoint3()
    {
        score3++;
    }
    public void AddPoint4()
    {
        score4++;
    }
    public void AddPoint5()
    {
        score5++;
    }
    public void AddPoint6()
    {
        score6++;
    }
    public void AddPoint7()
    {
        score7++;
    }
    public void AddPoint8()
    {
        score8++;
    }
    public void AddPoint9()
    {
        score9++;
    }
    public void AddPoint10()
    {
        score10++;
    }


}
