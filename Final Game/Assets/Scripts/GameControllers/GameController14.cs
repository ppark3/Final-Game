using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController14 : MonoBehaviour
{
    public int phase;

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
    public TMP_Text thirteen;

    public TMP_Text fourteen;
    public TMP_Text fifteen;
    public TMP_Text sixteen;
    public TMP_Text seventeen;
    public TMP_Text eighteen;
    public TMP_Text nineteen;

    public TMP_Text twenty;
    public TMP_Text twentyone;
    public TMP_Text twentytwo;

    public TMP_Text twentythree;
    public TMP_Text twentyfour;

    public TMP_Text twentyfive;

    public TMP_Text twentysix;
    public TMP_Text twentyseven;
    public TMP_Text twentyeight;
    public TMP_Text twentynine;

    public GameObject hey;

    public Camera cam;
    public Color redBackground;
    public Color startBackground;
    public float fadeTime;

    public GameObject stopper1;
    public GameObject stopper2;
    public GameObject brokenDoor;
    public GameObject stopper3;

    public GameObject gameWon;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.gameScene = 24;
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
            three.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && three.GetComponent<ScrollText>().isTyping)
        {
            three.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 2 && !three.GetComponent<ScrollText>().isTyping)
        {
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
        if (phase == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            three.gameObject.SetActive(false);
            four.gameObject.SetActive(false);
            five.gameObject.SetActive(false);
            hey.SetActive(true);
            six.gameObject.SetActive(true);
            phase = 6;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
        {
            phase = 4;
        }
        if (phase == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            five.gameObject.SetActive(true);
            phase = 5;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 6 && six.GetComponent<ScrollText>().isTyping)
        {
            six.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 6 && Input.GetKeyDown(KeyCode.Space) && !six.GetComponent<ScrollText>().isTyping)
        {
            phase = 7;
            six.gameObject.SetActive(false);
        }
        if (phase == 7)
        {
            seven.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && seven.GetComponent<ScrollText>().isTyping)
        {
            seven.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 7 && !seven.GetComponent<ScrollText>().isTyping)
        {
            phase = 8;
        }
        if (phase == 9 && Input.GetKeyDown(KeyCode.Space))
        {
            phase = 10;
        }
        if (phase == 8 && Input.GetKeyDown(KeyCode.Space))
        {
            eight.gameObject.SetActive(true);
            GameManager.uglyAsFuck = true;
            phase = 9;
        }
        if (phase == 10)
        {
            seven.gameObject.SetActive(false);
            eight.gameObject.SetActive(false);
            nine.gameObject.SetActive(true);
            phase = 11;
        }
        if (phase == 12 && nine.GetComponent<MoveTextRight>().landed && Input.GetKeyDown(KeyCode.Space))
        {
            ten.gameObject.SetActive(true);
        }
        if (phase == 11 && nine.GetComponent<MoveTextRight>().landed)
        {
            phase = 12;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 12 && ten.GetComponent<ScrollText>().isTyping)
        {
            ten.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 12 && !ten.GetComponent<ScrollText>().isTyping)
        {
            phase = 13;
        }
        if (phase == 13)
        {
            StartCoroutine(Ponder());
            phase = 14;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 16 && fourteen.GetComponent<ScrollText>().isTyping)
        {
            fourteen.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (phase == 15 && Input.GetKeyDown(KeyCode.Space))
        {
            nine.gameObject.SetActive(false);
            ten.gameObject.SetActive(false);
            eleven.gameObject.SetActive(false);
            twelve.gameObject.SetActive(false);
            thirteen.gameObject.SetActive(false);
            fourteen.gameObject.SetActive(true);
            phase = 16;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 16 && !fourteen.GetComponent<ScrollText>().isTyping)
        {
            GameManager.runningFootsteps = true;
            phase = 17;
        }
        if (phase == 17)
        {
            fifteen.gameObject.SetActive(true);
        }
        if (phase == 17 && Input.GetKeyDown(KeyCode.Space) && fifteen.GetComponent<FadeInText>().displayed)
        {
            phase = 18;
        }
        if (phase == 18)
        {
            fourteen.gameObject.SetActive(false);
            fifteen.gameObject.SetActive(false);
            sixteen.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 18 && sixteen.GetComponent<ScrollText>().isTyping)
        {
            sixteen.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 18 && !sixteen.GetComponent<ScrollText>().isTyping)
        {
            phase = 19;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 19 && !seventeen.GetComponent<SizePop>().displayed)
        {
            seventeen.GetComponent<SizePop>().Stop();
        }
        if (phase == 19)
        {
            stopper1.SetActive(false);
            stopper2.SetActive(true);
            seventeen.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 19 && seventeen.GetComponent<SizePop>().displayed)
        {
            phase = 20;
        }
        if (phase == 20)
        {
            eighteen.gameObject.SetActive(true);
        }
        if (phase == 20 && Input.GetKeyDown(KeyCode.Space) && eighteen.GetComponent<MoveTextLeft>().landed)
        {
            phase = 21;
        }
        if (phase == 21)
        {
            nineteen.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 21 && nineteen.GetComponent<ScrollText>().isTyping)
        {
            nineteen.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 21 && !nineteen.GetComponent<ScrollText>().isTyping)
        {
            phase = 22;
        }
        if (phase == 22)
        {
            sixteen.gameObject.SetActive(false);
            seventeen.gameObject.SetActive(false);
            eighteen.gameObject.SetActive(false);
            nineteen.gameObject.SetActive(false);
            twenty.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 22 && twenty.GetComponent<ScrollText>().isTyping)
        {
            twenty.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 22 && !twenty.GetComponent<ScrollText>().isTyping)
        {
            phase = 23;
        }
        if (phase == 23)
        {
            twentyone.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 23 && twentyone.GetComponent<ScrollText>().isTyping)
        {
            twentyone.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 23 && !twentyone.GetComponent<ScrollText>().isTyping)
        {
            GameManager.runningFootsteps = true;
            phase = 24;
        }
        if (phase == 24)
        {
            twentytwo.gameObject.SetActive(true);
        }
        if (phase == 24 && Input.GetKeyDown(KeyCode.Space) && twentytwo.GetComponent<FadeInText>().displayed)
        {
            phase = 25;
        }
        if (phase == 25)
        {
            twenty.gameObject.SetActive(false);
            twentyone.gameObject.SetActive(false);
            twentytwo.gameObject.SetActive(false);
            twentythree.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 25 && twentythree.GetComponent<ScrollText>().isTyping)
        {
            twentythree.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 25 && !twentythree.GetComponent<ScrollText>().isTyping)
        {
            phase = 26;
        }
        if (phase == 26)
        {
            twentyfour.gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 26 && twentyfour.GetComponent<ScrollText>().isTyping)
        {
            twentyfour.GetComponent<ScrollText>().cancelTyping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 26 && !twentyfour.GetComponent<ScrollText>().isTyping)
        {
            GameManager.slam = true;
            phase = 27;
        }
        if (phase == 27)
        {
            stopper2.SetActive(false);
            stopper1.SetActive(true);
            brokenDoor.SetActive(true);
            twentythree.gameObject.SetActive(false);
            twentyfour.gameObject.SetActive(false);
            twentyfive.gameObject.SetActive(true);
        }
        if (phase == 27 && Input.GetKeyDown(KeyCode.Space) && twentyfive.GetComponent<MoveTextRight>().landed)
        {
            phase = 28;
        }
        if (phase == 28)
        {
            stopper1.SetActive(false);
            brokenDoor.SetActive(false);
            stopper3.SetActive(true);
            twentyfive.gameObject.SetActive(false);
            twentysix.gameObject.SetActive(true);
        }
        if (phase == 28 && Input.GetKeyDown(KeyCode.Space) && twentysix.GetComponent<MoveTextUp>().landed)
        {
            phase = 29;
        }
        if (phase == 29)
        {
            twentyseven.gameObject.SetActive(true);
        }
        if (phase == 29 && Input.GetKeyDown(KeyCode.Space) && twentyseven.GetComponent<SlowFadeInText>().displayed)
        {
            //twentysix.gameObject.SetActive(false);
            //twentyseven.gameObject.SetActive(false);
            phase = 30;
        }

        if (phase == 30)
        {
            gameWon.SetActive(true);
            GameManager.playGameWonSong = true;
            phase = 31;
        }
        if (phase == 31 && gameWon.GetComponent<SlowFadeIn>().fadedIn)
        {
            twentyeight.gameObject.SetActive(true);
            phase = 32;
        }

        if (twentyeight.GetComponent<SlowScroll>().displayed)
        {
            twentynine.gameObject.SetActive(true);
        }

        if (phase == 32 && Input.GetKeyDown(KeyCode.R))
        {
            GameManager.gameScene = 0;
            SceneManager.LoadScene("Title Screen");
        }
    }

    IEnumerator Ponder()
    {
        StartCoroutine(ChangeBackground());
        eleven.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.35f);
        twelve.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.35f);
        thirteen.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.35f);
        phase = 15;
    }

    IEnumerator ChangeBackground()
    {
        fadeTime = 1f;
        for (float t = 0.0f; t < fadeTime; t += Time.deltaTime)
        {
            cam.backgroundColor = Color.Lerp(redBackground, startBackground, Mathf.Min(1, t / fadeTime));
            yield return null;
        }
    }
}
