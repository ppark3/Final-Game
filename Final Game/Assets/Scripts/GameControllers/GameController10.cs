using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController10 : MonoBehaviour
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
    public TMP_Text eight;
    public TMP_Text nine;
    public TMP_Text ten;
    public TMP_Text eleven;
    public TMP_Text twelve;

    // Start is called before the first frame update
    void Start()
    {
        totalTimerTime = 8;
        GameManager.gameScene = 18;
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
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<FadeInText>().displayed)
        {
            phase = 2;
        }
        if (phase == 1)
        {
            two.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<FadeInText>().displayed)
        {
            phase = 3;
        }
        if (phase == 2)
        {
            three.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<FadeInText>().displayed)
        {
            phase = 4;
        }
        if (phase == 3)
        {
            four.gameObject.SetActive(true);
        }
        if (phase == 4)
        {
            GameManager.footsteps = true;
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            phase = 5;
            StartCoroutine(WaitABit());
        }
        if (phase == 6)
        {
            five.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && five.GetComponent<ScrollText>().isTyping)
        {
            five.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && !five.GetComponent<ScrollText>().isTyping)
        {
            phase = 7;
        }
        if (phase == -1 && Input.GetKeyDown(KeyCode.Space))
        {
            eight.gameObject.SetActive(true);
            phase = 9;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && six.GetComponent<FadeInText>().displayed)
        {
            phase = 8;
        }
        if (phase == 7)
        {
            six.gameObject.SetActive(true);
        }
        if (phase == 8)
        {
            phase = -1;
            //GameManager.suddenly = true;
            GameManager.stopWalking = true;
            six.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            suddenly.gameObject.SetActive(true);
            seven.gameObject.SetActive(true);
        }
        if (phase == 9 && Input.GetKeyDown(KeyCode.Space) && eight.GetComponent<MoveTextRight>().landed)
        {
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            phase = 10;
        }
        if (phase == 10)
        {
            nine.gameObject.SetActive(true);
        }
        if (phase == 10 && nine.GetComponent<FadeInText>().displayed && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 11;
        }
        if (phase == 11)
        {
            ten.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 11 && ten.GetComponent<ScrollText>().isTyping)
        {
            ten.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 11 && !ten.GetComponent<ScrollText>().isTyping)
        {
            stopper.gameObject.SetActive(false);
            phase = 12;
        }
        if (phase == 12)
        {
            eleven.gameObject.SetActive(true);
        }
        if (phase == 12 && eleven.GetComponent<SlamBehavior>().landed && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 13;
        }
        if (phase == 13)
        {
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);
            eleven.gameObject.SetActive(false);
            twelve.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 13 && twelve.GetComponent<ScrollText>().isTyping)
        {
            twelve.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 13 && !twelve.GetComponent<ScrollText>().isTyping)
        {
            phase = 14;
        }
        if (phase == 14)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            StartCoroutine(RunTimer());
            phase = 15;
            decisionTime = true;
        }
        if (phase == 15 && decisionTime)
        {
            if (Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                twelve.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                GameManager.fifthChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 16;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                twelve.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                GameManager.fifthChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 16;
            }
        }
        if (phase == 16)
        {
            SceneManager.LoadScene("Scene11");
        }
    }

    IEnumerator WaitABit()
    {
        yield return new WaitForSeconds(3f);
        phase = 6;
    }

    void Hit()
    {
        eleven.GetComponent<SlamBehavior>().landed = true;
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
        twelve.gameObject.SetActive(false);
        GameManager.fifthChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 16;
    }
}
