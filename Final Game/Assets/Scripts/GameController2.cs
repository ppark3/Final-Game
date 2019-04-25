using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController2 : MonoBehaviour
{
    public int phase;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;

    public int totalTimerTime;
    public bool decisionTime;

    public float assistTimer;
    public TMP_Text one;
    public TMP_Text one5;

    // Start is called before the first frame update
    void Start()
    {
        totalTimerTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (phase == 0)
        {
            one.gameObject.SetActive(true);
            one5.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && one5.GetComponent<ScrollText>().displayed)
        {
            phase = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !(one.GetComponent<ScrollText>().displayed || one5.GetComponent<ScrollText>().displayed))
        {
            one.GetComponent<ScrollText>().cancelTyping = true;
            one5.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 1)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            StartCoroutine(RunTimer());
            phase = 2;
            decisionTime = true;
        }
        if (phase == 2 && decisionTime)
        {
            if(Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<GoodChoiceBehavior>().selectedBool)
            {
                one.gameObject.SetActive(false);
                one5.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.firstChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 3;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<BadChoiceBehavior>().selectedBool)
            {
                one.gameObject.SetActive(false);
                one5.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.firstChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 3;
            }
        }
        if (phase == 3)
        {
            if (GameManager.firstChoice == 1)
            {
                SceneManager.LoadScene("Scene3");
            }
            if (GameManager.firstChoice == 2)
            {
                SceneManager.LoadScene("Scene4");
            }
            if (GameManager.firstChoice == 3)
            {
                SceneManager.LoadScene("Scene5");
            }
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
        one.gameObject.SetActive(false);
        one5.gameObject.SetActive(false);
        GameManager.firstChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 3;
    }
}
