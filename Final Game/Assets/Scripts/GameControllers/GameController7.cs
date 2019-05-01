using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController7 : MonoBehaviour
{
    public int phase;

    public Coroutine fuckCoroutine;

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
        phase = 0;
        //GameManager.gameScene = 12;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameScene == 11)
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
                one.gameObject.SetActive(false);
                two.gameObject.SetActive(false);
                three.gameObject.SetActive(false);
                four.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<ScrollText>().isTyping)
            {
                four.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && !five.GetComponent<SizePop>().displayed)
            {
                five.SendMessage("Stop");
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
            {
                phase = 4;
            }
            if (phase == 4)
            {
                five.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && five.GetComponent<SizePop>().displayed)
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
                GameManager.gameScene = 14;
                SceneManager.LoadScene("Scene8");
            }
        }
        else if (GameManager.gameScene == 12)
        {
            if (phase == 0)
            {
                seven.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && seven.GetComponent<ScrollText>().isTyping)
            {
                seven.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !seven.GetComponent<ScrollText>().isTyping)
            {
                phase = 1;
            }
            if (phase == 1)
            {
                eight.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && eight.GetComponent<ScrollText>().isTyping)
            {
                eight.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 1 && !eight.GetComponent<ScrollText>().isTyping)
            {
                GameManager.fuckYou2 = true;
                fuckCoroutine = StartCoroutine(WaitforFuck());
                phase = 2;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && (nine.gameObject.activeSelf || ten.gameObject.activeSelf))
            {
                Stop();
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3)
            {
                phase = 4;
            }
            if (phase == 4)
            {
                seven.gameObject.SetActive(false);
                eight.gameObject.SetActive(false);
                nine.gameObject.SetActive(false);
                ten.gameObject.SetActive(false);
                eleven.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && eleven.GetComponent<ScrollText>().isTyping)
            {
                eleven.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && !eleven.GetComponent<ScrollText>().isTyping)
            {
                GameManager.gameScene = 14;
                SceneManager.LoadScene("Scene8");
            }

        }
        else if (GameManager.gameScene == 13)
        {
            if (phase == 0)
            {
                twelve.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && twelve.GetComponent<ScrollText>().isTyping)
            {
                twelve.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 0 && !twelve.GetComponent<ScrollText>().isTyping)
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
                twelve.gameObject.SetActive(false);
                two.gameObject.SetActive(false);
                three.gameObject.SetActive(false);
                four.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<ScrollText>().isTyping)
            {
                four.GetComponent<ScrollText>().cancelTyping = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && !five.GetComponent<SizePop>().displayed)
            {
                five.SendMessage("Stop");
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && !four.GetComponent<ScrollText>().isTyping)
            {
                phase = 4;
            }
            if (phase == 4)
            {
                five.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && phase == 4 && five.GetComponent<SizePop>().displayed)
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
                GameManager.gameScene = 14;
                SceneManager.LoadScene("Scene8");
            }
        }
    }

    IEnumerator WaitforFuck()
    {
        nine.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        nine.gameObject.SetActive(false);
        ten.gameObject.SetActive(true);
        phase = 3;
    }

    void Stop()
    {
        StopCoroutine(fuckCoroutine);
        nine.gameObject.SetActive(false);
        ten.gameObject.SetActive(true);
        phase = 3;
    }
}
