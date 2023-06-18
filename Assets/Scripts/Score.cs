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

    //clicks
    public int clicks;

    //score values
    public int score1value = 1;
    public int score2value = 2;
    public int score3value = 3;
    public int score4value = 4;
    public int score5value = 5;
    public int score6value = 6;
    public int score7value = 7;
    public int score8value = 8;
    public int score9value = 9;
    public int score10value = 10;

    //sym + avg
    public int sum;
    public int avg;

    //txt
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

    public TextMeshProUGUI avgText;

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

        avgText.text = avg.ToString();
    }

    public void AddPoint1()
    {
        score1++;
        clicks++;
        CountAvg();
    }
    public void AddPoint2()
    {
        score2++;
        clicks++;
        CountAvg();
    }
    public void AddPoint3()
    {
        score3++;
        clicks++;
        CountAvg();
    }
    public void AddPoint4()
    {
        score4++;
        clicks++;
        CountAvg();
    }
    public void AddPoint5()
    {
        score5++;
        clicks++;
        CountAvg();
    }
    public void AddPoint6()
    {
        score6++;
        clicks++;
        CountAvg();
    }
    public void AddPoint7()
    {
        score7++;
        clicks++;
        CountAvg();
    }
    public void AddPoint8()
    {
        score8++;
        clicks++;
        CountAvg();
    }
    public void AddPoint9()
    {
        score9++;
        clicks++;
        CountAvg();
    }
    public void AddPoint10()
    {
        score10++;
        clicks++;
        CountAvg();
    }

    //statistics
    public void CountAvg()
    {
        sum = score1*score1value + score2*score2value + score3*score3value + score4*score4value + score5*score5value + score6*score6value + score7*score7value + score8*score8value + score9*score9value + score10*score10value;
        avg = sum/clicks;
    }

}
