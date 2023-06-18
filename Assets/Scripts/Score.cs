using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{   
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;
    public GameObject Panel8;
    public GameObject Panel9;
    public GameObject Panel10;

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

    //maxscore
    public int scoremax;

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
    public TextMeshProUGUI scoremaxText;

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
        scoremaxText.text = scoremax.ToString();
    }

    public void AddPoint1()
    {
        score1++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint2()
    {
        score2++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint3()
    {
        score3++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint4()
    {
        score4++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint5()
    {
        score5++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint6()
    {
        score6++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint7()
    {
        score7++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint8()
    {
        score8++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint9()
    {
        score9++;
        clicks++;
        CountAvg();
        MaxScore();
    }
    public void AddPoint10()
    {
        score10++;
        clicks++;
        CountAvg();
        MaxScore();
    }

    //statistics
    public void CountAvg()
    {
        sum = score1*score1value + score2*score2value + score3*score3value + score4*score4value + score5*score5value + score6*score6value + score7*score7value + score8*score8value + score9*score9value + score10*score10value;
        avg = sum/clicks;
    }

    public void MaxScore()
    {
        if (score1>score2 && score1>score3 && score1>score4 && score1>score5 && score1>score6 && score1>score7 && score1>score8 && score1>score9 && score1>score10)
        {
            scoremax = score1value;
        }
        if (score2>score1 && score2>score3 && score2>score4 && score2>score5 && score2>score6 && score2>score7 && score2>score8 && score2>score9 && score2>score10)
        {
            scoremax = score2value;
        }
        if (score3>score1 && score3>score2 && score3>score4 && score3>score5 && score3>score6 && score3>score7 && score3>score8 && score3>score9 && score3>score10)
        {
            scoremax = score3value;
        }
        if (score4>score1 && score4>score2 && score4>score3 && score4>score5 && score4>score6 && score4>score7 && score4>score8 && score4>score9 && score4>score10)
        {
            scoremax = score4value;
        }
        if (score5>score1 && score5>score2 && score5>score3 && score5>score4 && score5>score6 && score5>score7 && score5>score8 && score5>score9 && score5>score10)
        {
            scoremax = score5value;
        }
        if (score6>score1 && score6>score2 && score6>score3 && score6>score4 && score6>score5 && score6>score7 && score6>score8 && score6>score9 && score6>score10)
        {
            scoremax = score6value;
        }
        if (score7>score1 && score7>score2 && score7>score3 && score7>score4 && score7>score5 && score7>score6 && score7>score8 && score7>score9 && score7>score10)
        {
            scoremax = score7value;
        }
        if (score8>score1 && score8>score2 && score8>score3 && score8>score4 && score8>score5 && score8>score6 && score8>score7 && score8>score9 && score1>score10)
        {
            scoremax = score8value;
        }
        if (score9>score1 && score9>score2 && score9>score3 && score9>score4 && score9>score5 && score9>score6 && score9>score7 && score9>score8 && score9>score10)
        {
            scoremax = score9value;
        }
        if (score10>score1 && score10>score2 && score10>score3 && score10>score4 && score10>score5 && score10>score6 && score10>score7 && score10>score8 && score10>score9)
        {
            scoremax = score10value;
        }

        switch (avg) 
        {
            case 1:
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel1.SetActive(true);
                break;
            case 2:
                Panel1.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel2.SetActive(true);
                break;
            case 3:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel3.SetActive(true);
                break;
            case 4:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel4.SetActive(true);
                break;
            case 5:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel5.SetActive(true);
                break;
            case 6:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel6.SetActive(true);
                break;
            case 7:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel7.SetActive(true);
                break;
            case 8:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel8.SetActive(true);
                break;
            case 9:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(false);
                Panel9.SetActive(true);
                break;
            case 10:
                Panel1.SetActive(false);
                Panel2.SetActive(false);
                Panel3.SetActive(false);
                Panel4.SetActive(false);
                Panel5.SetActive(false);
                Panel6.SetActive(false);
                Panel7.SetActive(false);
                Panel8.SetActive(false);
                Panel9.SetActive(false);
                Panel10.SetActive(true);
                break;

        }

    
        
    }

}
