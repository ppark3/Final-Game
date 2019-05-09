using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController12 : MonoBehaviour
{
    public int phase;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;
    public GameObject runResponse1;
    public GameObject runResponse2;
    public GameObject runResponse3;
    public GameObject runResponse4;
    public bool triedRunning;
    public Coroutine runningHelp;

    public int totalTimerTime;
    public bool decisionTime;
    public bool stoppedMusic;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;
    public TMP_Text five;
    public TMP_Text six;
    public TMP_Text seven;
    public TMP_Text eight;
    public TMP_Text nine;
    public TMP_Text ten;
    public TMP_Text eleven;

    // Start is called before the first frame update
    void Start()
    {
        totalTimerTime = 8;
        triedRunning = false;
        GameManager.gameScene = 22;
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
            if (!stoppedMusic)
            {
                GameManager.stopMusic = true;
                stoppedMusic = true;
            }
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
        if (phase == 9)
        {
            seven.gameObject.SetActive(true);
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            if (!triedRunning)
            {
                runResponse1.SetActive(true);
            }
            else
            {
                runResponse4.SetActive(true);
            }
            runningHelp = StartCoroutine(RunTimer());
            phase = 10;
            decisionTime = true;
        }
        if (phase == 10 && decisionTime)
        {

            if (Input.GetKey(KeyCode.Space) && runResponse1.GetComponent<ChoiceBehavior>().selectedBool && !triedRunning)
            {
                runResponse1.gameObject.SetActive(false);
                runResponse2.gameObject.SetActive(true);
            }
            if (Input.GetKey(KeyCode.Space) && runResponse2.GetComponent<ChoiceBehavior>().selectedBool && !triedRunning)
            {
                runResponse2.gameObject.SetActive(false);
                runResponse3.gameObject.SetActive(true);
            }
            if (Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(runningHelp);
                GameManager.sixthChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                runResponse1.SetActive(false);
                runResponse2.SetActive(false);
                runResponse3.SetActive(false);
                runResponse4.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 13;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(runningHelp);
                GameManager.sixthChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                runResponse1.SetActive(false);
                runResponse2.SetActive(false);
                runResponse3.SetActive(false);
                runResponse4.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 12;
            }
            if (Input.GetKey(KeyCode.Space) && runResponse3.GetComponent<ChoiceBehavior>().selectedBool && !triedRunning)
            {
                timer.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(runningHelp);
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                runResponse3.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                GameManager.stopMusicAbruptly = true;
                triedRunning = true;
                eight.gameObject.SetActive(true);
                phase = -10;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == -10 && !eight.GetComponent<SlowScroll>().isTyping)
        {
            eight.gameObject.SetActive(false);
            phase = 9;
            GameManager.playThirdSong = true;
        }
        if (phase == 11)
        {
            GameManager.gameScene = 23;
            SceneManager.LoadScene("Scene13");
        }
        if (phase == 12)
        {
            nine.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 12 && nine.GetComponent<ScrollText>().isTyping)
        {
            nine.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 12 && !nine.GetComponent<ScrollText>().isTyping)
        {
            GameManager.gameScene = -1;
            SceneManager.LoadScene("GameOver");
        }
        if (phase == 13)
        {
            ten.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 13 && ten.GetComponent<ScrollText>().isTyping)
        {
            ten.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 13 && !ten.GetComponent<ScrollText>().isTyping)
        {
            phase = 11;
        }
        if (phase == 14)
        {
            eleven.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 14 && eleven.GetComponent<ScrollText>().isTyping)
        {
            eleven.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 14 && !eleven.GetComponent<ScrollText>().isTyping)
        {
            phase = 11;
        }
    }

    public IEnumerator RunTimer()
    {
        timer.gameObject.SetActive(true);
        timer.value = 1;
        for (float t = 0.0f; t < totalTimerTime; t += Time.deltaTime)
        {
            timer.value = Mathf.Lerp(1, 0, Mathf.Min(1, t / totalTimerTime));
            yield return null;
        }
        timer.gameObject.SetActive(false);
        seven.gameObject.SetActive(false);
        GameManager.sixthChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        runResponse1.SetActive(false);
        runResponse2.SetActive(false);
        runResponse3.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 14;
    }
}
