using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip firstSong;
    public AudioClip secondSong;
    public AudioClip climaxSong;
    public AudioClip gameOver;
    public AudioClip gameWon;

    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = firstSong;
        audioSource.Play();
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.stopMusic)
        {
            audioSource.Stop();
            GameManager.stopMusic = false;
        }
        if (GameManager.playSecondSong)
        {
            audioSource.clip = secondSong;
            audioSource.Play();
            GameManager.playSecondSong = false;
        }
        if (GameManager.playThirdSong)
        {
            audioSource.clip = climaxSong;
            audioSource.Play();
            GameManager.playThirdSong = false;
        }
    }
}
