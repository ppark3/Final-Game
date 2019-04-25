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

    public bool firstChoice = true;

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
    }
}
