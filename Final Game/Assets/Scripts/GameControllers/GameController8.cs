using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController8 : MonoBehaviour
{
    public int phase;
    public float assistTimer;

    public GameObject cursor;
    public Slider timer;
    public GameObject goodResponse;
    public GameObject badRepsonse;

    public int totalTimerTime;
    public bool decisionTime;

    public GameObject stopper;
    public GameObject top;
    public GameObject bottom;
    public GameObject left;
    public GameObject right;

    public GameObject bloodFilter;
    public bool raved = false;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;

    public TMP_Text four;
    public TMP_Text five;

    public TMP_Text six; //ooooo no music part

    public TMP_Text seven; //ooooo no music part

    public TMP_Text eight; //back to music
    public TMP_Text nine; //back to music


    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
        totalTimerTime = 8;
        //GameManager.gameScene = 14;
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
            GameManager.fadeFootsteps = true;
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
        if (phase == 1 && two.GetComponent<ScrollText>().displayed)
        {
            assistTimer += Time.deltaTime;
            if (assistTimer > 0.5f)
            {
                three.gameObject.SetActive(true);
                assistTimer = 0.0f;
            }
        }
        if (phase == 1 && three.GetComponent<FadeInText>().displayed && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 2;
        }
        if (phase == 2)
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(true);
        }
        if (phase == 2 && four.GetComponent<SlamBehavior>().landed && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 3;
        }
        if (phase == 3)
        {
            five.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && five.GetComponent<ScrollText>().isTyping)
        {
            five.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 4)
        {
            GameManager.stopMusic = true;
            six.gameObject.SetActive(true);
            phase = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !five.GetComponent<ScrollText>().isTyping)
        {
            phase = 4;
        }

        if (phase == 7 && Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.scream = true;
            StartCoroutine(RedRaveParty());
            phase = 8;
        }

        if (phase == 6 && Input.GetKeyDown(KeyCode.Space))
        {
            seven.SendMessage("Shake");
            phase = 7;
        }

        if (phase == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(true);
            phase = 6;
        }

        if (raved && phase == 8)
        {
            GameManager.playSecondSong = true;
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(true);
            phase = 9;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 9 && eight.GetComponent<ScrollText>().isTyping)
        {
            eight.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 9 && !eight.GetComponent<ScrollText>().isTyping)
        {
            phase = 10;
        }
        if (phase == 10)
        {
            nine.gameObject.SetActive(true);
            stopper.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 10 && nine.GetComponent<ScrollText>().isTyping)
        {
            nine.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 10 && !nine.GetComponent<ScrollText>().isTyping)
        {
            phase = 11;
        }
        if (phase == 11)
        {
            cursor.SetActive(true);
            goodResponse.SetActive(true);
            badRepsonse.SetActive(true);
            StartCoroutine(RunTimer());
            phase = 12;
            decisionTime = true;
        }
        if (phase == 12 && decisionTime)
        {
            if (Input.GetKey(KeyCode.Space) && goodResponse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                eight.gameObject.SetActive(false);
                nine.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                GameManager.fourthChoice = 1;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 13;
            }
            if (Input.GetKey(KeyCode.Space) && badRepsonse.GetComponent<ChoiceBehavior>().selectedBool)
            {
                timer.gameObject.SetActive(false);
                eight.gameObject.SetActive(false);
                nine.gameObject.SetActive(false);
                StopCoroutine(RunTimer());
                GameManager.fourthChoice = 2;
                goodResponse.SetActive(false);
                badRepsonse.SetActive(false);
                cursor.SetActive(false);
                decisionTime = false;
                phase = 13;
            }
        }
        if (phase == 13)
        {
            SceneManager.LoadScene("Scene9");
        }
    }

    void Hit()
    {
        four.GetComponent<SlamBehavior>().landed = true;
    }

    IEnumerator RedRaveParty()
    {
        yield return new WaitForSeconds(0.01f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        bloodFilter.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.05f);
        raved = true;
        yield return null;
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
        eight.gameObject.SetActive(false);
        nine.gameObject.SetActive(false);
        GameManager.fourthChoice = 3;
        goodResponse.SetActive(false);
        badRepsonse.SetActive(false);
        cursor.SetActive(false);
        decisionTime = false;
        phase = 13;
    }
}
