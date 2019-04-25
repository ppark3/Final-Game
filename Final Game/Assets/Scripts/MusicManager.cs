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
        
    }
}
