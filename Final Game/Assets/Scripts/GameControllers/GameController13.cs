using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController13 : MonoBehaviour
    // game scene is 23
{
    public int phase;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;
    public bool decisionTime;
    public int totalTimerTime;
    public Coroutine runningHelp;

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

    public Camera cam;
    public Color redBackground;
    public Color startBackground;
    public float fadeTime;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.gameScene = 23;
        totalTimerTime = 8;
    }

    // Update is called once per frame
    void Update()
    {
        if (phase == 0)
        {
            one.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && one.GetComponent<ScrollText>().isTyping)
        {
            one.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !one.GetComponent<ScrollText>().isTyping)
        {
            one.gameObject.SetActive(false);
            phase = 1;
        }
        if (phase == 1)
        {
            two.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<ScrollText>().isTyping)
        {
            two.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !two.GetComponent<ScrollText>().isTyping)
        {
            phase = 2;
        }
        if (phase == 2)
        {
            three.gameObject.SetActive(true);
        }
        if (phase == 3 && Input.GetKeyDown(KeyCode.Space) && !four.GetComponent<ScrollText>().isTyping)
        {
            four.gameObject.SetActive(false);
            phase = 4;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<FadeInText>().displayed)
        {
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            phase = 3;
        }
        if (phase == 3)
        {
            four.gameObject.SetActive(true);
        }
        if (phase == 4)
        {
            StartCoroutine(ChangeBackground());
            five.gameObject.SetActive(true);
            phase = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 5 && !five.GetComponent<SlowScroll>().isTyping)
        {
            phase = 6;
        }
        if (phase == 6)
        {
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && six.GetComponent<ScrollText>().isTyping)
        {
            six.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && !six.GetComponent<ScrollText>().isTyping)
        {
            phase = 7;
        }
        if (phase == 7)
        {
            seven.gameObject.SetActive(true);
        }
        /*if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && seven.GetComponent<SlowScroll>().isTyping)
        {
            seven.GetComponent<SlowScroll>().cancelTyping = true;
        }*/
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && !seven.GetComponent<SlowScroll>().isTyping)
        {
            phase = 8;
        }
        if (phase == 8)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            runningHelp = StartCoroutine(RunTimer());
            phase = 9;
            decisionTime = true;
        }
        if (phase == 9 && decisionTime)
        {
            if (Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(runningHelp);
                GameManager.seventhChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 10;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(runningHelp);
                GameManager.seventhChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 12;
            }
        }
        if (phase == 10)
        {
            ten.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 10 && ten.GetComponent<ScrollText>().isTyping)
        {
            ten.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 10 && !ten.GetComponent<ScrollText>().isTyping)
        {
            GameManager.gameScene = -1;
            SceneManager.LoadScene("GameOver3");
        }
        if (phase == 11)
        {
            if (GameManager.FriendDecision() >= 0)
            {
                GameManager.gameScene = 24;
                SceneManager.LoadScene("Scene14");
            }
            else if (GameManager.FriendDecision() < 0)
            {
                GameManager.gameScene = -1;
                SceneManager.LoadScene("Scene14Bad");
            }
        }
        if (phase == 12)
        {
            eight.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 12 && eight.GetComponent<ScrollText>().isTyping)
        {
            eight.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 12 && !eight.GetComponent<ScrollText>().isTyping)
        {
            GameManager.gameScene = -1;
            SceneManager.LoadScene("GameOver2");
        }
    }

    IEnumerator ChangeBackground()
    {
        fadeTime = 5f;
        for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
        {
            cam.backgroundColor = Color.Lerp(startBackground, redBackground, Mathf.Min(1, t / fadeTime));
            yield return null;
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
        six.gameObject.SetActive(false);
        seven.gameObject.SetActive(false);
        GameManager.seventhChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 11;
    }
}
