using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController6 : MonoBehaviour
{
    public int phase;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;

    public int totalTimerTime;
    public bool decisionTime;

    public ParticleSystem first;
    public ParticleSystem second;
    public ParticleSystem third;

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
            GameManager.crackFloor = true;
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
        if (phase == 2)
        {
            three.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !two.GetComponent<ScrollText>().isTyping)
        {
            phase = 2;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<FadeInText>().displayed)
        {
            phase = 4;
        }

        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<FadeInText>().displayed)
        {
            four.GetComponent<FadeInText>().Stop();
        }
        if (phase == 2 && three.GetComponent<SlamBehavior>().landed && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 3;
        }
        if (phase == 3)
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            first.gameObject.SetActive(false);
            second.gameObject.SetActive(false);
            third.gameObject.SetActive(false);
            four.gameObject.SetActive(true);
        }
        if (phase == 4)
        {
            five.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && five.GetComponent<ScrollText>().isTyping)
        {
            five.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && !five.GetComponent<ScrollText>().isTyping)
        {
            phase = 5;
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
            seven.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && seven.GetComponent<ScrollText>().isTyping)
        {
            seven.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && !seven.GetComponent<ScrollText>().isTyping)
        {
            phase = 7;
        }
        if (phase == 7)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            StartCoroutine(RunTimer());
            phase = 8;
            decisionTime = true;
        }
        if (phase == 8 && decisionTime)
        {
            if (Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                four.gameObject.SetActive(false);
                five.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.thirdChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 9;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                four.gameObject.SetActive(false);
                five.gameObject.SetActive(false);
                six.gameObject.SetActive(false);
                seven.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.thirdChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 9;
            }
        }
        if (phase == 9)
        {
            SceneManager.LoadScene("Scene7");
        }
    }

    void Hit()
    {
        first.gameObject.SetActive(true);
        second.gameObject.SetActive(true);
        third.gameObject.SetActive(true);
        three.GetComponent<SlamBehavior>().landed = true;
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
        four.gameObject.SetActive(false);
        five.gameObject.SetActive(false);
        six.gameObject.SetActive(false);
        seven.gameObject.SetActive(false);
        GameManager.thirdChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 9;
    }
}
