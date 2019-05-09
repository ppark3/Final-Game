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

    public Coroutine stopMusic;
    public Coroutine stopMusic2;

    public float startVolume;

    // Start is called before the first frame update
    void Start()
    {
        startVolume = audioSource.volume;
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
            if (GameManager.gameScene == 14)
            {
                GameManager.stopMusic = false;
                stopMusic = StartCoroutine(FadeOut(audioSource, 0.5f));
            }
            else if (GameManager.gameScene == 22)
            {
                GameManager.stopMusic = false;
                stopMusic2 = StartCoroutine(FadeOut(audioSource, 0.5f));
            }
        }
        if (GameManager.stopMusicAbruptly)
        {
            audioSource.Stop();
            GameManager.stopMusicAbruptly = false;
        }
        if (GameManager.playSecondSong)
        {
            StopCoroutine(stopMusic);
            audioSource.Stop();
            audioSource.volume = startVolume;
            audioSource.clip = secondSong;
            audioSource.Play();
            GameManager.playSecondSong = false;
        }
        if (GameManager.playThirdSong)
        {
            StopCoroutine(stopMusic2);
            audioSource.Stop();
            audioSource.volume = startVolume;
            audioSource.clip = climaxSong;
            audioSource.Play();
            GameManager.playThirdSong = false;
        }
        if (GameManager.playGameOverSong)
        {
            StartCoroutine(GameOver(audioSource, 1f));
            GameManager.playGameOverSong = false;
        }
        if (GameManager.playGameWonSong)
        {
            StartCoroutine(GameWon(audioSource, 1f));
            GameManager.playGameWonSong = false;
        }
    }

    public IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float start = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= start * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = start;
    }

    public IEnumerator GameOver(AudioSource audioSource, float FadeTime)
    {
        float start = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= start * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = start; 
        audioSource.clip = gameOver;
        audioSource.Play();
    }


    public IEnumerator GameWon(AudioSource audioSource, float FadeTime)
    {
        float start = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= start * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = start;
        audioSource.clip = gameWon;
        audioSource.Play();
    }
}
