using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip creakingFloor;
    public AudioClip doorOpening;
    public AudioClip fadeInRunning;
    public AudioClip fadeOutRunning;
    public AudioClip floorBreaking;
    public AudioClip lightWalking;
    public AudioClip scaryLaugh;
    public AudioClip scream;
    public AudioClip stab;
    public AudioClip select;
    public AudioClip gong;

    public bool firstChoice = true;
    public bool secondChoice = true;
    public bool thirdChoice = true;
    public bool fourthChoice = true;
    public bool fifthChoice = true;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.firstChoice != 0 && firstChoice)
        {
            audioSource.clip = select;
            audioSource.Play();
            firstChoice = false;
        }
        if (GameManager.gameScene == 4 && GameManager.screwYou)
        {
            audioSource.clip = gong;
            audioSource.Play();
            GameManager.screwYou = false;
        }
        if (GameManager.gameScene == 6 && GameManager.creakyFloor)
        {
            audioSource.Stop();
            audioSource.clip = creakingFloor;
            audioSource.Play();
            GameManager.creakyFloor = false;
        }
        if (GameManager.gameScene == 6 && GameManager.hey)
        {
            audioSource.Stop();
            audioSource.clip = select;
            audioSource.Play();
            GameManager.hey = false;
        }
        if (GameManager.secondChoice != 0 && secondChoice)
        {
            audioSource.clip = select;
            audioSource.Play();
            secondChoice = false;
        }
        if (GameManager.gameScene == 8 && GameManager.fuckYou)
        {
            audioSource.clip = gong;
            audioSource.Play();
            GameManager.fuckYou = false;
        }
        if (GameManager.gameScene == 10 && GameManager.crackFloor)
        {
            audioSource.clip = floorBreaking;
            audioSource.Play();
            GameManager.crackFloor = false;
        }
        if (GameManager.thirdChoice != 0 && thirdChoice)
        {
            audioSource.clip = select;
            audioSource.Play();
            thirdChoice = false;
        }
        if (GameManager.fourthChoice != 0 && fourthChoice)
        {
            audioSource.clip = select;
            audioSource.Play();
            fourthChoice = false;
        }
        if (GameManager.fifthChoice != 0 && fifthChoice)
        {
            audioSource.clip = select;
            audioSource.Play();
            fifthChoice = false;
        }
        if (GameManager.gameScene == 14 && GameManager.fadeFootsteps)
        {
            audioSource.Stop();
            audioSource.clip = fadeOutRunning;
            audioSource.Play();
            GameManager.fadeFootsteps = false;
        }
        if (GameManager.gameScene == 12 && GameManager.fuckYou2)
        {
            audioSource.clip = gong;
            audioSource.Play();
            GameManager.fuckYou2 = false;
        }
        if (GameManager.gameScene == 14 && GameManager.scream)
        {
            audioSource.clip = scream;
            audioSource.Play();
            GameManager.scream = false;
        }
        if (GameManager.gameScene == 18 && GameManager.footsteps)
        {
            audioSource.Stop();
            audioSource.clip = lightWalking;
            audioSource.Play();
            GameManager.footsteps = false;
        }
        if (GameManager.gameScene == 18 && GameManager.suddenly)
        {
            audioSource.Stop();
            audioSource.clip = select;
            audioSource.Play();
            GameManager.suddenly = false;
        }
        if (GameManager.gameScene == 22 && GameManager.walkTowards)
        {
            audioSource.Stop();
            audioSource.clip = lightWalking;
            audioSource.Play();
            GameManager.walkTowards = false;
        }
        if (GameManager.gameScene == 22 && GameManager.stopWalking)
        {
            audioSource.Stop();
            GameManager.stopWalking = false;
        }

    }
}
