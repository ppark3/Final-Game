using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver3 : MonoBehaviour
{
    public int phase;

    public GameObject redBlanket;
    public GameObject gameOver;
    public GameObject hider;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;
    public TMP_Text four;
    public TMP_Text five;
    public TMP_Text six;

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
        if (phase == 0 && Input.GetKeyDown(KeyCode.Space) && one.GetComponent<FadeInText>().displayed)
        {
            phase = 1;
            two.gameObject.SetActive(true);
        }
        if (phase == 2 && Input.GetKeyDown(KeyCode.Space) && !three.GetComponent<AppearText>().reached2)
        {
            three.GetComponent<AppearText>().finish = true;
        }
        if (phase == 1 && Input.GetKeyDown(KeyCode.Space) && two.GetComponent<FadeInText>().displayed)
        {
            phase = 2;
            one.gameObject.SetActive(false);
            two.gameObject.SetActive(false);
            hider.gameObject.SetActive(true);
            three.gameObject.SetActive(true);
        }
        if (phase == 2 && Input.GetKeyDown(KeyCode.Space) && three.GetComponent<AppearText>().reached2)
        {
            four.gameObject.SetActive(true);
            phase = 3;
        }
        if (Input.GetKeyDown(KeyCode.Space) && phase == 3 && four.GetComponent<ScrollText>().isTyping)
        {
            four.GetComponent<ScrollText>().cancelTyping = true;
        }
    }
}
