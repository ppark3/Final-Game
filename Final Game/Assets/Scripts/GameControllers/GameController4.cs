using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController4 : MonoBehaviour
{
    public int phase;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;

    public int totalTimerTime;
    public bool decisionTime;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;

    public TMP_Text four;

    public TMP_Text five; //hey!
    public GameObject hey;
    public TMP_Text six;


    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
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
            GameManager.creakyFloor = true;
            phase = 2;
        }
        if (phase == 2)
        {
            three.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<ScrollText>().isTyping)
        {
            three.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && !three.GetComponent<ScrollText>().isTyping)
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            phase = 3;
        }
        if (phase == 3)
        {
            four.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<ScrollText>().isTyping)
        {
            four.GetComponent<ScrollText>().cancelTyping = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && phase == 4)
        {
            phase = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
        {
            four.gameObject.SetActive(false);
            phase = 4;
            GameManager.hey = true;
        }
        if (phase == 4)
        {
            five.gameObject.SetActive(true);
            hey.gameObject.SetActive(true);
        }
        if (phase == 5)
        {
            six.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 5 && six.GetComponent<ScrollText>().isTyping)
        {
            six.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 5 && !six.GetComponent<ScrollText>().isTyping)
        {
            phase = 6;
        }
        if (phase == 6)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            StartCoroutine(RunTimer());
            phase = 7;
            decisionTime = true;
        }
        if (phase == 7 && decisionTime)
        {
            if (Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                five.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.secondChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 8;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                five.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.secondChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 8;
            }
        }
        if (phase == 8)
        {
            SceneManager.LoadScene("Scene5");
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
        five.gameObject.SetActive(false);
        GameManager.secondChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 8;
    }
}
