using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{

    // public int score1;
    public int score1Save;
    public int score2Save;
    public int score3Save;
    public int score4Save;
    public int score5Save;
    public int score6Save;
    public int score7Save;
    public int score8Save;
    public int score9Save;
    public int score10Save;

    // Start is called before the first frame update
    void Start()
    {
        score1Save = PlayerPrefs.GetInt("score1Save", 0);
        score2Save = PlayerPrefs.GetInt("score2Save", 0);
        score3Save = PlayerPrefs.GetInt("score3Save", 0);
        score4Save = PlayerPrefs.GetInt("score4Save", 0);
        score5Save = PlayerPrefs.GetInt("score5Save", 0);
        score6Save = PlayerPrefs.GetInt("score6Save", 0);
        score7Save = PlayerPrefs.GetInt("score7Save", 0);
        score8Save = PlayerPrefs.GetInt("score8Save", 0);
        score9Save = PlayerPrefs.GetInt("score9Save", 0);
        score10Save = PlayerPrefs.GetInt("score10Save", 0);

        GameObject.Find("ScoreScript").GetComponent<Score>().score1 = score1Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score2 = score2Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score3 = score3Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score4 = score4Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score5 = score5Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score6 = score6Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score7 = score7Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score8 = score8Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score9 = score9Save;
        GameObject.Find("ScoreScript").GetComponent<Score>().score10 = score10Save;
    }

    // Update is called once per frame
    void Update()
    {
        score1Save = GameObject.Find("ScoreScript").GetComponent<Score>().score1;
        score2Save = GameObject.Find("ScoreScript").GetComponent<Score>().score2;
        score3Save = GameObject.Find("ScoreScript").GetComponent<Score>().score3;
        score4Save = GameObject.Find("ScoreScript").GetComponent<Score>().score4;
        score5Save = GameObject.Find("ScoreScript").GetComponent<Score>().score5;
        score6Save = GameObject.Find("ScoreScript").GetComponent<Score>().score6;
        score7Save = GameObject.Find("ScoreScript").GetComponent<Score>().score7;
        score8Save = GameObject.Find("ScoreScript").GetComponent<Score>().score8;
        score9Save = GameObject.Find("ScoreScript").GetComponent<Score>().score9;
        score10Save = GameObject.Find("ScoreScript").GetComponent<Score>().score10;
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("score1Save",score1Save);
        PlayerPrefs.SetInt("score2Save",score2Save);
        PlayerPrefs.SetInt("score3Save",score3Save);
        PlayerPrefs.SetInt("score4Save",score4Save);
        PlayerPrefs.SetInt("score5Save",score5Save);
        PlayerPrefs.SetInt("score6Save",score6Save);
        PlayerPrefs.SetInt("score7Save",score7Save);
        PlayerPrefs.SetInt("score8Save",score8Save);
        PlayerPrefs.SetInt("score9Save",score9Save);
        PlayerPrefs.SetInt("score10Save",score10Save);
        PlayerPrefs.Save();

    }

    public void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("score1Save",score1Save);
        PlayerPrefs.SetInt("score2Save",score2Save);
        PlayerPrefs.SetInt("score3Save",score3Save);
        PlayerPrefs.SetInt("score4Save",score4Save);
        PlayerPrefs.SetInt("score5Save",score5Save);
        PlayerPrefs.SetInt("score6Save",score6Save);
        PlayerPrefs.SetInt("score7Save",score7Save);
        PlayerPrefs.SetInt("score8Save",score8Save);
        PlayerPrefs.SetInt("score9Save",score9Save);
        PlayerPrefs.SetInt("score10Save",score10Save);
        PlayerPrefs.Save();

    }
}
