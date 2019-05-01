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

    public ParticleSystem first;
    public ParticleSystem second;
    public ParticleSystem third;

    public TMP_Text one;
    public TMP_Text two;
    public TMP_Text three;

    public TMP_Text four;


    // Start is called before the first frame update
    void Start()
    {
        phase = 0;
        totalTimerTime = 8;
        GameManager.gameScene = 14;
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
    }

    void Hit()
    {
        four.GetComponent<SlamBehavior>().landed = true;
    }
}
