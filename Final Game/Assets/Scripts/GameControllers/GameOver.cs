using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public int phase;

    public GameObject redBlanket;
    public GameObject gameOver;

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

    public TMP_Text eight;
    public TMP_Text nine;

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
        if (phase == 0 && Input.GetKeyDown(KeyCode.Space) && !one.GetComponent<AppearText>().reached2)
        {
            one.GetComponent<AppearText>().finish = true;
        }
        if (phase == 0 && Input.GetKeyDown(KeyCode.Space) && one.GetComponent<AppearText>().reached2)
        {
            two.gameObject.SetActive(true);
            phase = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && two.GetComponent<ScrollText>().isTyping)
        {
            two.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(BloodSplatter());
        }
        if (phase == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(true);
            phase = 5;
        }
        if (phase == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 4;
            //four.gameObject.SetActive(true);
            GameManager.stab = true;
            redBlanket.gameObject.SetActive(false);
            redBlanket.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !two.GetComponent<ScrollText>().isTyping)
        {
            phase = 2;
        }
        if (phase == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 3;
            //three.gameObject.SetActive(true);
            GameManager.stab = true;
            redBlanket.gameObject.SetActive(true);
        }
        if (phase == 6)
        {
            six.gameObject.SetActive(true);
            phase = 7;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && six.GetComponent<FadeInText>().displayed)
        {
            phase = 8;
        }
        if (phase == 8)
        {
            five.gameObject.SetActive(false);
            six.gameObject.SetActive(false);
            seven.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 8 && seven.GetComponent<FadeInText>().displayed)
        {
            phase = 9;
        }
        if (phase == 9)
        {
            gameOver.SetActive(true);
            GameManager.playGameOverSong = true;
            phase = 10;
        }
        if (phase == 10 && gameOver.GetComponent<SlowFadeIn>().fadedIn)
        {
            eight.gameObject.SetActive(true);
            nine.gameObject.SetActive(true);
            phase = 11;
        }
        if (phase == 11 && Input.GetKeyDown(KeyCode.R))
        {
            GameManager.gameScene = 0;
            SceneManager.LoadScene("Title Screen");
        }
    }

    IEnumerator BloodSplatter()
    {
        first.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        second.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        third.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        phase = 6;
    }
}
