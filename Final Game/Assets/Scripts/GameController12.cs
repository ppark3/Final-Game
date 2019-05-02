using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController12 : MonoBehaviour
{
    public int phase;
    public float assistTimer;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;

    public int totalTimerTime;
    public bool decisionTime;

    public GameObject suddenly;
    public GameObject down;
    public GameObject stopper;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;
    public TMP_Text five;
    public TMP_Text six;
    public TMP_Text seven;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (phase == 0)
        {
            one.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && one.GetComponent<FadeInText>().displayed)
        {
            phase = 1;
        }
        if (phase == 1)
        {
            two.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<FadeInText>().displayed)
        {
            phase = 2;
        }
        if (phase == 2)
        {
            GameManager.walkTowards = true;
            three.gameObject.SetActive(true);
            phase = 3;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && three.GetComponent<FadeInText>().displayed)
        {
            phase = 4;
        }
        if (phase == 4)
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            GameManager.stopWalking = true;
            four.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && four.GetComponent<FadeInText>().displayed)
        {
            phase = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 5 && five.GetComponent<FadeInText>().displayed)
        {
            phase = 6;
        }
        if (phase == 5)
        {
            GameManager.stopMusic = true;
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(true);
            five.GetComponent<FadeInText>().displayed = true;
        }
        if (phase == 6)
        {
            GameManager.playThirdSong = true;
            phase = 7;
            six.gameObject.SetActive(true);
        }/*
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && six.GetComponent<SlowScroll>().isTyping)
        {
            five.GetComponent<SlowScroll>().cancelTyping = true;
        }*/
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && !six.GetComponent<SlowScroll>().isTyping)
        {
            phase = 8;
        }
        if (phase == 8)
        {
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 8 && !seven.GetComponent<SlowScroll>().isTyping)
        {
            phase = 9;
        }
    }
}
