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
    public TMP_Text two;

    // Start is called before the first frame update
    void Start()
    {
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
            phase = 2;
        }
        if (phase == 2)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            StartCoroutine(RunTimer());
            phase = 3;
            decisionTime = true;
        }
        if (phase == 3 && decisionTime)
        {
            if(Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                one.gameObject.SetActive(false);
                two.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.firstChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 4;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                one.gameObject.SetActive(false);
                two.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                timer.gameObject.SetActive(false);
                GameManager.firstChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 4;
            }
        }
        if (phase == 4)
        {
            SceneManager.LoadScene("Scene3");
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
        two.gameObject.SetActive(false);
        GameManager.firstChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 4;
    }
}
